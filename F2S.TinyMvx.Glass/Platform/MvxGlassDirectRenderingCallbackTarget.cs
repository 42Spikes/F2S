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

namespace F2S.TinyMvx
{
    public interface IMvxDirectRenderingCallbackWrapper
    {
        void RenderingPaused(ISurfaceHolder holder, bool paused);
        void SurfaceChanged(ISurfaceHolder holder, Android.Graphics.Format format, int width, int height);
        void SurfaceCreated(ISurfaceHolder holder);
        void SurfaceDestroyed(ISurfaceHolder holder);
    }

    // this is wonky because of the need to derive from Jave.Lang.Object to deal with IDirectRenderingCallback.Handle
    public class DirectRenderingCallbackWrapper : Java.Lang.Object, IDirectRenderingCallback
    {
        private IMvxDirectRenderingCallbackWrapper _renderer;

        public DirectRenderingCallbackWrapper(IMvxDirectRenderingCallbackWrapper renderer)
        {
            // TODO: Complete member initialization
            _renderer = renderer;
        }
        public void RenderingPaused(ISurfaceHolder p0, bool paused)
        {
            _renderer.RenderingPaused(p0, paused);
        }

        public void SurfaceChanged(ISurfaceHolder holder, Android.Graphics.Format format, int width, int height)
        {
            _renderer.SurfaceChanged(holder, format, width, height);
        }

        public void SurfaceCreated(ISurfaceHolder holder)
        {
            _renderer.SurfaceCreated(holder);
        }

        public void SurfaceDestroyed(ISurfaceHolder holder)
        {
            _renderer.SurfaceDestroyed(holder);
        }
    }

    public abstract class MvxGlassDirectRenderingCallbackTarget : IMvxDirectRenderingCallbackWrapper
    {
        private DirectRenderingCallbackWrapper _renderingCallbackWrapper;
        public DirectRenderingCallbackWrapper RenderingCallbackWrapper { get { return _renderingCallbackWrapper; } }

        public MvxGlassDirectRenderingCallbackTarget(IMvxService service)
        {
            _renderingCallbackWrapper = new DirectRenderingCallbackWrapper(this);
        }

        public virtual void attachedService(IMvxService service)
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