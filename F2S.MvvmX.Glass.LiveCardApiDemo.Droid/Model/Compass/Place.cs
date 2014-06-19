using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace F2S.MvvmX.Glass.LiveCardApiDemo.Model.Compass
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