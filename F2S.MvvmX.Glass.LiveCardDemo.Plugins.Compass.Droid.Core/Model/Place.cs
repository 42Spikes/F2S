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

namespace F2S.MvvmX.Glass.LiveCardDemo.Plugins.Compass.Droid.Model
{
    public class Place
    {
        public double Latitiude { get; set; }
        public double Longitude { get; set; }
        public string Name { get; set; }

        public Place()
        {
            
        }

        public Place(double latitude, double longitude, string name)
        {
            Latitiude = latitude;
            Longitude = longitude;
            Name = name;
        }
    }
}