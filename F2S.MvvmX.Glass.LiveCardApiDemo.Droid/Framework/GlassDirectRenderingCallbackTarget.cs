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
using F2S.MvvmX.Glass.LiveCardApiDemo.Droid.Util;

namespace F2S.MvvmX.Glass.LiveCardApiDemo.Droid.Framework
{
    public abstract class GlassDirectRenderingCallbackTarget : IMvxDirectRenderingCallbackWrapper
    {
        private DirectRenderingCallbackWrapper _renderingCallbackWrapper;
        public DirectRenderingCallbackWrapper RenderingCallbackWrapper { get { return _renderingCallbackWrapper; } }

        public GlassDirectRenderingCallbackTarget(GlassMvxService service)
        {
            _renderingCallbackWrapper = new DirectRenderingCallbackWrapper(this);
        }

        public virtual void attachedService(GlassMvxService service)
        {
        }

        public virtual void RenderingPaused(ISurfaceHolder holder, bool paused)
        {
        }

        public virtual void SurfaceChanged(ISurfaceHolder holder, Android.Graphics.Format format, int width, int height)
        {
        }

        public virtual void SurfaceCreated(ISurfaceHolder holder)
        {
        }

        public virtual void SurfaceDestroyed(ISurfaceHolder holder)
        {
        }
    }
}