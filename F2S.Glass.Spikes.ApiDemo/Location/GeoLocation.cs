using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace F2S.Glass.Spikes.ApiDemo.Location
{
    public class GeoLocation
    {
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public double Altitude { get; set; }
        public long Time { get; set; }

        public GeoLocation()
        {
        }
    }
}