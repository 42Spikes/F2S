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

namespace F2S.MvvmX.Glass.LiveCardApiDemo.Droid.Util
{
    public abstract class MathUtils
    {
        private static int NUMBER_OF_HALF_WINDS = 16;
        private static double EARTH_RADIUS_KM = 6371.0;

        public static int getHalfWindIndex(double heading)
        {
            var partitionSize = 360.0f / NUMBER_OF_HALF_WINDS;
            var displacedHeading = MathUtils.mod(heading + partitionSize / 2, 360.0f);
            return (int)(displacedHeading / partitionSize);
        }

        public static int mod(int a, int b)
        {
            return (a % b + b) % b;
        }

        public static double mod(double a, double b)
        {
            return (a % b + b) % b;
        }

        public static double getBearing(double latitude1, double longitude1, double latitude2, double longitude2)
        {
            latitude1 = latitude1.toRadians();
            longitude1 = longitude1.toRadians();
            latitude2 = latitude2.toRadians();
            longitude2 = longitude2.toRadians();

            var dLon = longitude2 - longitude1;

            var y = Math.Sin(dLon) * Math.Cos(latitude2);
            var x = Math.Cos(latitude1) * Math.Sin(latitude2) - Math.Sin(latitude1)
                    * Math.Cos(latitude2) * Math.Cos(dLon);

            var bearing = Math.Atan2(y, x);
            return mod(bearing.toDegrees(), 360.0);
        }

        public static double getDistance(double latitude1, double longitude1, double latitude2, double longitude2)
        {
            double dLat = (latitude2 - latitude1).toRadians();
            double dLon = (longitude2 - longitude1).toRadians();
            double lat1 = (latitude1).toRadians();
            double lat2 = (latitude2).toRadians();
            double sqrtHaversineLat = Math.Sin(dLat / 2);
            double sqrtHaversineLon = Math.Sin(dLon / 2);
            double a = sqrtHaversineLat * sqrtHaversineLat + sqrtHaversineLon * sqrtHaversineLon
                    * Math.Cos(lat1) * Math.Cos(lat2);
            double c = 2 * Math.Atan2(Math.Sqrt(a), Math.Sqrt(1 - a));

            return (float)(EARTH_RADIUS_KM * c);
        }
    }

    public static class MathExtensions
    {
        public static double toRadians(this double degrees)
        {
            return (Math.PI / 180.0) * degrees;
        }

        public static double toDegrees(this double radians)
        {
            return radians * (180.0 / Math.PI);
        }

        public static float toRadians(this float degrees)
        {
            return (float)((Math.PI / 180.0) * degrees);
        }

        public static float toDegrees(this float radians)
        {
            return (float)(radians * (180.0 / Math.PI));
        }
    }
}