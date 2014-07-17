using System;
using System.Collections.Generic;
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
    public class LocationListener : Java.Lang.Object, ILocationListener
    {
        public Action<Android.Locations.Location> LocationChanged { get; set; }
        public Action<string> ProviderDisabled { get; set; }
        public Action<string> ProviderEnabled { get; set; }
        public Action<string, Availability, Bundle> StatusChanged { get; set; }

        public void OnLocationChanged(Android.Locations.Location location)
        {
            if (LocationChanged != null) LocationChanged(location);
        }

        public void OnProviderDisabled(string provider)
        {
            if (ProviderDisabled != null) ProviderDisabled(provider);
        }

        public void OnProviderEnabled(string provider)
        {
            if (ProviderEnabled != null) ProviderEnabled(provider);
        }

        public void OnStatusChanged(string provider, Availability status, Bundle extras)
        {
            if (StatusChanged != null) StatusChanged(provider, status, extras);
        }
    }
}