using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.Glass.Timeline;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace F2S.MvvmX.Glass.Compass.Droid.Util
{
    // this is wonky because of the need to derive from Jave.Lang.Object to deal with IDirectRenderingCallback.Handle
    public class RenderingCallbackWrapper : Java.Lang.Object, IDirectRenderingCallback
    {
        private CompassRenderer _compassRenderer;

        public RenderingCallbackWrapper(CompassRenderer compassRenderer)
        {
            // TODO: Complete member initialization
            _compassRenderer = compassRenderer;
        }
        public void RenderingPaused(ISurfaceHolder p0, bool p1)
        {
            _compassRenderer.RenderingPaused(p0, p1);
        }

        public void SurfaceChanged(ISurfaceHolder holder, Android.Graphics.Format format, int width, int height)
        {
            _compassRenderer.SurfaceChanged(holder, format, width, height);
        }

        public void SurfaceCreated(ISurfaceHolder holder)
        {
            _compassRenderer.SurfaceCreated(holder);
        }

        public void SurfaceDestroyed(ISurfaceHolder holder)
        {
            _compassRenderer.SurfaceDestroyed(holder);
        }
    }
}