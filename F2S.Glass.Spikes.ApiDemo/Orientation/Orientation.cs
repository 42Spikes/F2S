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

namespace F2S.Glass.Spikes.ApiDemo.Orientation
{
    public class Orientation
    {
        public double Heading { get; set; }
        public double Pitch { get; set; }

        public Orientation()
        {
            
        }

        public Orientation(double heading, double pitch)
        {
            Heading = heading;
            Pitch = pitch;
        }
    }
}