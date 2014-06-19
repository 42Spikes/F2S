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

namespace F2S.MvvmX.Glass.Compass.Droid.Util
{
    public class OnChangedListener : Java.Lang.Object, OrientationManager.IOnChangedListener
    {
        private OrientationManager.IOnChangedListener _callback;

        public OnChangedListener(OrientationManager.IOnChangedListener callback)
        {
            _callback = callback;
        }

        public void OnOrientationChanged(OrientationManager orientationManager)
        {
            _callback.OnOrientationChanged(orientationManager);
        }

        public void OnLocationChanged(OrientationManager orientationManager)
        {
            _callback.OnLocationChanged(orientationManager);
        }

        public void OnAccuracyChanged(OrientationManager orientationManager)
        {
            _callback.OnAccuracyChanged(orientationManager);
        }
    }
}