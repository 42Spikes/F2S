using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using F2S.MvvmX.Glass.LiveCardDemo.Plugins.Compass.Core.Util;
using Newtonsoft.Json;

namespace F2S.MvvmX.Glass.LiveCardDemo.Plugins.Compass.Core.Model
{
    public class Landmarks
    {
        public List<Place> Places { get; set; }

        private const double _maxDistanceKM = 10.0;
 
        public Landmarks(string landmarksAsJSON)
        {
            Places = new List<Place>();    

            // read a list of places
            populatePlaceList(landmarksAsJSON);
        }

        private void populatePlaceList(string json)
        {
            var places = JsonConvert.DeserializeObject<List<Place>>(json);
            Places = places;
        }

        internal List<Place> getNearbyLandmarks(double latitude, double longitude)
        {
            var nearby =
                Places.Where(
                    p => MathUtils.getDistance(
                        latitude, longitude,
                        p.Latitiude, p.Longitude) < _maxDistanceKM)
                    .ToList();
            return nearby;
        }
    }
}