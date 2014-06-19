using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Java.Lang;
using Java.IO;
using Java.Security.Cert;
using Newtonsoft.Json;
using Exception = System.Exception;
using IOException = Java.IO.IOException;
using F2S.MvvmX.Glass.LiveCardDemo.Plugins.Compass.Droid.Util;

namespace F2S.MvvmX.Glass.LiveCardDemo.Plugins.Compass.Droid.Model
{
    public class Landmarks
    {
        public List<Place> Places { get; set; }

        private const double _maxDistanceKM = 10.0;
 
        public Landmarks(Context context)
        {
            Places = new List<Place>();    

            // read a list of places
            var json = readLandmarksResource(context);
            populatePlaceList(json);
        }

        private void populatePlaceList(string json)
        {
            var places = JsonConvert.DeserializeObject<List<Place>>(json);
            Places = places;
        }

        private static string readLandmarksResource(Context context)
        {
            string content;
            using (var sr = new StreamReader(context.Resources.OpenRawResource(Resource.Raw.landmarks)))
            {
                content = sr.ReadToEnd();
            }

            return content;
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