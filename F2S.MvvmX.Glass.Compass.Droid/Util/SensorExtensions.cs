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
using Android.Views;
using Android.Widget;

namespace F2S.MvvmX.Glass.Compass.Droid.Util
{
    public static class SensorExtensions
    {
        public static SensorManager getSensorManager(this Service service)
        {
            return (SensorManager)service.GetSystemService(Context.SensorService);
        }
        public static LocationManager getLocationManager(this Service service)
        {
            var ls = (LocationManager)service.GetSystemService(Context.LocationService);
            var hasPGS = ls.IsProviderEnabled(LocationManager.GpsProvider); 
            var hasNET = ls.IsProviderEnabled(LocationManager.NetworkProvider);
            return ls;
        }
    }
}