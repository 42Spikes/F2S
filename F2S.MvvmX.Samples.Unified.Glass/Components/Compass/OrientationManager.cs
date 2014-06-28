using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.Hardware;
using Android.Locations;
using Android.OS;
using Android.Runtime;
using Android.Util;
using Android.Views;
using Android.Widget;
using F2S.MvvmX.Samples.Unified.Glass.Components.Compass.Utils;
using F2S.MvvmX.Samples.Unified.Glass.ViewModels;

namespace F2S.MvvmX.Samples.Unified.Glass.Components.Compass
{
    public class OrientationManager : Java.Lang.Object, ISensorEventListener, ILocationListener
    {
        private static OrientationManager _instance;
        public static OrientationManager Instance { get { return _instance; } }
        /**
     * The minimum distance desired between location notifications.
     */
        private static long METERS_BETWEEN_LOCATIONS = 2;

        /**
     * The minimum elapsed time desired between location notifications.
     */
        private static long MILLIS_BETWEEN_LOCATIONS = (long)TimeSpan.FromMilliseconds(3).TotalMilliseconds;

        /**
     * The maximum age of a location retrieved from the passive location provider before it is
     * considered too old to use when the compass first starts up.
     */
        private static float MAX_LOCATION_AGE_MILLIS = (float)TimeSpan.FromMilliseconds(30).TotalMilliseconds;

        /**
     * The sensors used by the compass are mounted in the movable arm on Glass. Depending on how
     * this arm is rotated, it may produce a displacement ranging anywhere from 0 to about 12
     * degrees. Since there is no way to know exactly how far the arm is rotated, we just split the
     * difference.
     */
        private static int ARM_DISPLACEMENT_DEGREES = 6;

        public float Heading { get; private set; }

        private SensorManager _sensorManager;
        private LocationManager _locationManager;

        public interface IOnChangedListener
        {
            /**
             * Called when the user's orientation changes.
             *
             * @param orientationManager the orientation manager that detected the change
             */
            void OnOrientationChanged(OrientationManager orientationManager);

            /**
             * Called when the user's location changes.
             *
             * @param orientationManager the orientation manager that detected the change
             */
            void OnLocationChanged(OrientationManager orientationManager);

            /**
             * Called when the accuracy of the compass changes.
             *
             * @param orientationManager the orientation manager that detected the change
             */
            void OnAccuracyChanged(OrientationManager orientationManager);
        }

        public float Pitch { get; private set; }
        public Location Location { get; private set; }
        public bool HasInterference { get; private set; }

        private List<IOnChangedListener> _listeners = new List<IOnChangedListener>();

        private float[] _rotationMatrix;
        private float[] _orientation;

        private bool _tracking;
        private float _pitch;
        private GeomagneticField _geomagneticField;

        public bool HasLocation
        {
            get { return Location != null; }
        }

        public OrientationManager(SensorManager sensorManager, LocationManager locationManager)
        {
            _instance = this;

            _sensorManager = sensorManager;
            _locationManager = locationManager;

            _rotationMatrix = new float[16];
            _orientation = new float[9];
        }

        /**
         * Adds a listener that will be notified when the user's location or orientation changes.
         */

        public void addOnChangedListener(IOnChangedListener listener)
        {
            _listeners.Add(listener);
        }

        /**
         * Removes a listener from the list of those that will be notified when the user's location or
         * orientation changes.
         */

        public void removeOnChangedListener(IOnChangedListener listener)
        {
            _listeners.Remove(listener);
        }

        #region ISensorEventListener

        public void OnAccuracyChanged(Sensor sensor, SensorStatus accuracy)
        {
            if (sensor.Type == SensorType.MagneticField)
            {
                HasInterference = (accuracy < SensorStatus.AccuracyHigh);
                notifyAccuracyChanged();
            }
        }

        public void OnSensorChanged(SensorEvent e)
        {
            if (e.Sensor.Type == SensorType.RotationVector)
            {
                // Get the current heading from the sensor, then notify the listeners of the
                // change.
                SensorManager.GetRotationMatrixFromVector(_rotationMatrix, e.Values.ToArray());
                SensorManager.RemapCoordinateSystem(
                    _rotationMatrix,
                    Android.Hardware.Axis.X,
                    Android.Hardware.Axis.Z,
                    _rotationMatrix);
                SensorManager.GetOrientation(_rotationMatrix, _orientation);

                // Store the pitch (used to display a message indicating that the user's head
                // angle is too steep to produce reliable results.
                _pitch = _orientation[1].toDegrees();

                // Convert the heading (which is relative to magnetic north) to one that is
                // relative to true north, using the user's current location to compute this.
                var magneticHeading = _orientation[0].toDegrees();
                Heading = (float)MathUtils.mod(computeTrueNorth(magneticHeading), 360.0f) - ARM_DISPLACEMENT_DEGREES;

                notifyOrientationChanged();
            }
        }

        #endregion

        public void start()
        {
            try
            {
                if (!_tracking)
                {
                    _sensorManager.RegisterListener(
                        this,
                        _sensorManager.GetDefaultSensor(SensorType.RotationVector),
                        SensorDelay.Ui);

                    // The rotation vector sensor doesn't give us accuracy updates, so we observe the
                    // magnetic field sensor solely for those.
                    _sensorManager.RegisterListener(this,
                        _sensorManager.GetDefaultSensor(SensorType.MagneticField),
                        SensorDelay.Ui);

                    var lastLocation = _locationManager.GetLastKnownLocation(LocationManager.PassiveProvider);
                    if (lastLocation != null)
                    {
                        var locationAge = lastLocation.Time - DateTime.Now.Ticks;
                        if (locationAge < MAX_LOCATION_AGE_MILLIS)
                        {
                            Location = lastLocation;
                            updateGeomagneticField();
                        }
                    }

                    var criteria = new Criteria();
                    criteria.Accuracy = Accuracy.Fine;
                    criteria.BearingRequired = false;
                    criteria.SpeedRequired = false;

                    var providers = _locationManager.GetProviders(criteria, true /* enabledOnly */);

                    foreach (var provider in providers)
                    {
                        _locationManager.RequestLocationUpdates(
                            provider,
                            MILLIS_BETWEEN_LOCATIONS,
                            METERS_BETWEEN_LOCATIONS,
                            this,
                            Looper.MainLooper);
                    }

                    _tracking = true;

                    //OnLocationChanged(new Location() { Latitude = 40.096300, Longitude = -75.412868 });
                }
            }
            catch (Exception e)
            {
                Log.Debug("Exception", e.Message);
            }
        }

        /**
             * Stops tracking the user's location and orientation. Listeners will no longer be notified of
             * these events.
             */

        public void stop()
        {
            if (_tracking)
            {
                _sensorManager.UnregisterListener(this);
                _locationManager.RemoveUpdates(this);
                _tracking = false;
            }
        }

        public void OnLocationChanged(Location location)
        {
            Location = location;
            updateGeomagneticField();
            notifyLocationChanged();
        }

        public void OnProviderDisabled(string provider)
        {
        }

        public void OnProviderEnabled(string provider)
        {
        }

        public void OnStatusChanged(string provider, Availability status, Bundle extras)
        {
        }

        private void notifyOrientationChanged()
        {
            foreach (var listener in _listeners)
            {
                listener.OnOrientationChanged(this);
            }
        }

        /**
         * Notifies all listeners that the user's location has changed.
         */
        private void notifyLocationChanged()
        {
            foreach (var listener in _listeners)
            {
                listener.OnLocationChanged(this);
            }
        }

        /**
         * Notifies all listeners that the compass's accuracy has changed.
         */
        private void notifyAccuracyChanged()
        {
            foreach (var listener in _listeners)
            {
                listener.OnAccuracyChanged(this);
            }
        }

        /**
         * Updates the cached instance of the geomagnetic field after a location change.
         */
        private void updateGeomagneticField()
        {
            _geomagneticField = new GeomagneticField((float)Location.Latitude,
                (float)Location.Longitude, (float)Location.Altitude,
                Location.Time);
        }

        /**
         * Use the magnetic field to compute true (geographic) north from the specified heading
         * relative to magnetic north.
         *
         * @param heading the heading (in degrees) relative to magnetic north
         * @return the heading (in degrees) relative to true north
         */
        private float computeTrueNorth(float heading)
        {
            if (_geomagneticField != null)
            {
                return heading + _geomagneticField.Declination;
            }
            else
            {
                return heading;
            }
        }
    }
}