using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.Locations;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace F2S.Glass.Spikes.ApiDemo.Location
{
    public class LocationManagerFacade : INotifyPropertyChanged
    {
        private Context _context;
        public LocationManager _locationManager;

        private LocationListener _listener;

        private bool _tracking = false;
        private long _minTimeBetweenLocations = 5000;

        public GeoLocation _location = new GeoLocation()
        {
            Time = DateTime.Now.Ticks
        };

        public GeoLocation Location
        {
            get { return _location; }
            set
            {
                if (value != _location)
                {
                    if (_location != null)
                    {
                        var lastLocationAge = _location.Time - value.Time;
                        if (lastLocationAge < _minTimeBetweenLocations) return;
                    }

                    _location = value;
                    notifyPropertyChanged("Location");
                }
            }
        }

        public LocationManagerFacade(Context context)
        {
            _context = context;
            _listener = new LocationListener()
            {
                LocationChanged = locationChanged
            };
        }

        public void start()
        {
            if (_tracking) return;

            var ls = (LocationManager) _context.GetSystemService(Context.LocationService);
            //var aproviders = ls.AllProviders.ToArray();
            //var hasGPS = ls.IsProviderEnabled(LocationManager.GpsProvider);
            //var hasNET = ls.IsProviderEnabled(LocationManager.NetworkProvider);

            //if (!hasGPS || !hasNET)
            {
                //throw new Exception("Must have both GPS and Net location providers");
            }

            _locationManager = ls;

            var lastLocation = _locationManager.GetLastKnownLocation(LocationManager.PassiveProvider);
            Location = createGeoLocation(lastLocation);

            var criteria = new Criteria();
            criteria.Accuracy = Accuracy.Fine;
            criteria.AltitudeRequired = true;

            var providers = _locationManager.GetProviders(criteria, true).ToArray();
            foreach (var provider in providers)
            {
                _locationManager.RequestLocationUpdates(provider, 1000, 5, _listener, Looper.MainLooper);
            }

            _tracking = true;
        }

        public void stop()
        {
            if (_tracking)
            {
                _locationManager.RemoveUpdates(_listener);
                _tracking = false;
            }
        }

        private void locationChanged(Android.Locations.Location location)
        {
            Location = createGeoLocation(location);
        }

        private GeoLocation createGeoLocation(Android.Locations.Location location)
        {
            return new GeoLocation()
            {
                Latitude = location.Latitude,
                Longitude = location.Longitude,
                Altitude = location.Altitude,
                Time = location.Time
            };
        }

        private void notifyPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
        public event PropertyChangedEventHandler PropertyChanged;
    }
}