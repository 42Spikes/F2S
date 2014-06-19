using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Android.App;
using Android.Content;
using Android.Glass.Timeline;
using Android.Graphics;
using Android.OS;
using Android.Runtime;
using Android.Util;
using Android.Views;
using Android.Widget;
using F2S.MvvmX.Glass.Compass.Droid;
using F2S.MvvmX.Glass.LiveCardApiDemo.Droid.Framework;
using F2S.MvvmX.Glass.LiveCardApiDemo.Droid.Services.Compass;
using Java.Util.Concurrent;
using F2S.MvvmX.Glass.LiveCardApiDemo.Model.Compass;
using F2S.MvvmX.Glass.LiveCardApiDemo.Droid.Util;

namespace F2S.MvvmX.Glass.LiveCardApiDemo.Droid.Views.Compass
{
    public class CompassRenderer : GlassDirectRenderingCallbackTarget, OrientationManager.IOnChangedListener
    {
        private OrientationManager _orientationManager;
        private Landmarks _landmarks;

        private string TAG = typeof (CompassRenderer).Name;

        private const double TOO_STEEP_PITCH_DEGREES = 70.0;
        private const double REFRESH_RATE_FPS = 45.0;

        private static int FRAME_TIME_MILLIS = (int) (TimeSpan.FromSeconds(1).TotalMilliseconds/REFRESH_RATE_FPS);

        private FrameLayout _layout;
        private RelativeLayout _tipsContainer;
        private TextView _tipsView;

        private CompassView _compassView;

        public CompassView CompassView
        {
            get { return _compassView; }
            set { _compassView = value; }
        }

        private bool _tooSteep;
        private bool _interference;
        private int _surfaceWidth;
        private int _surfaceHeight;
        private bool _renderingPaused;
        private ISurfaceHolder _holder;
        private Task _renderTask;

        private OnChangedListener _onChangedListener;

        public CompassRenderer(GlassMvxService service) : base(service)
        {
            try
            {
                _onChangedListener = new OnChangedListener(this);

                var inflater = LayoutInflater.From(service);
                _layout = (FrameLayout)inflater.Inflate(Resource.Layout.compass, null);
                _layout.SetWillNotDraw(false);

                _compassView = (CompassView)_layout.FindViewById(Resource.Id.compass);
                _tipsContainer = (RelativeLayout)_layout.FindViewById(Resource.Id.tips_container);

                _tipsView = (TextView) _layout.FindViewById(Resource.Id.tips_view);
            }
            catch (Exception e)
            {
                Log.Debug("Exception", e.Message);
                Log.Debug("Exception", e.InnerException.Message);
            }
        }

        public override void attachedService(GlassMvxService service)
        {
            var s = service as CompassService;
            _compassView.OrientationManager = s.OrientationManager;
        }

        #region OrientationManager.IOnChangedListener

        public void OnOrientationChanged(OrientationManager orientationManager)
        {
            _compassView.Heading = _orientationManager.Heading;
            var oldTooSteep = _tooSteep;
            _tooSteep = Math.Abs(_orientationManager.Pitch) > TOO_STEEP_PITCH_DEGREES;
            if (_tooSteep != oldTooSteep)
            {
                updateTipsView();
            }
        }

        public void OnLocationChanged(OrientationManager orientationManager)
        {
            var location = _orientationManager.Location;
            var places = _landmarks.getNearbyLandmarks(location.Latitude, location.Longitude);
            _compassView.NearbyPlaces = places;
        }

        public void OnAccuracyChanged(OrientationManager orientationManager)
        {
            _interference = _orientationManager.HasInterference;
            updateTipsView();
        }

        #endregion

        #region IDirectRenderingCallback

        public override void SurfaceChanged(ISurfaceHolder holder, Format format, int width, int height)
        {
            _surfaceWidth = width;
            _surfaceHeight = height;
            doLayout();
        }

        public override void SurfaceCreated(ISurfaceHolder holder)
        {
            _renderingPaused = false;
            _holder = holder;
            updateRenderingState();
        }

        public override void SurfaceDestroyed(ISurfaceHolder holder)
        {
            _holder = null;
            updateRenderingState();
        }

        public override void RenderingPaused(ISurfaceHolder p0, bool p1)
        {
            _renderingPaused = true;
            updateRenderingState();
        }

        #endregion

        private void updateTipsView()
        {
            var stringId = 0;

            // Only one message (with magnetic interference being higher priority than pitch too steep)
            // will be displayed in the tip.
            if (_interference) 
            {
                stringId = Resource.String.magnetic_interference;
            } else if (_tooSteep) 
            {
                stringId = Resource.String.pitch_too_steep;
            }

            var show = (stringId != 0);

            if (show) 
            {
                _tipsView.SetText(stringId);
                doLayout();
            }

            if (_tipsContainer.Animation == null) 
            {
                var newAlpha = (show ? 1.0f : 0.0f);
                _tipsContainer.Animate().Alpha(newAlpha).Start();
            }
        }

        private void doLayout()
        {
            // Measure and update the layout so that it will take up the entire surface space
            // when it is drawn.
            var measuredWidth = View.MeasureSpec.MakeMeasureSpec(_surfaceWidth, MeasureSpecMode.Exactly);
            var measuredHeight = View.MeasureSpec.MakeMeasureSpec(_surfaceHeight, MeasureSpecMode.Exactly);

            _layout.Measure(measuredWidth, measuredHeight);
            _layout.Layout(0, 0, _layout.MeasuredWidth, _layout.MeasuredHeight);
        }

        private object _lock = new object();
        private void repaint()
        {
            lock (_lock)
            {
                Canvas canvas = null;
                try 
                {
                    canvas = _holder.LockCanvas();
                }
                catch (Exception e)
                {
                    Log.Debug(TAG, "lock canvas failed", e);
                }

                if (canvas != null)
                {
                    canvas.DrawColor(Color.Black);
                    _layout.Draw(canvas);
                    try
                    {
                        _holder.UnlockCanvasAndPost(canvas);
                    }
                    catch (Exception e)
                    {
                        Log.Debug(TAG, "unlockCanvasAndPost failed", e);
                    }
                }
            }
        }

        private CancellationToken _cancelToken;

        private void updateRenderingState()
        {
            var shouldRender = (_holder != null) && !_renderingPaused;
            var isRendering = (_renderTask != null);

            if (shouldRender != isRendering)
            {
                if (shouldRender)
                {
                    _orientationManager.addOnChangedListener(_onChangedListener);
                    _orientationManager.start();

                    if (_orientationManager.HasLocation)
                    {
                        var location = _orientationManager.Location;
                        var nearbyPlaces = _landmarks.getNearbyLandmarks(location.Latitude, location.Longitude);
                        _compassView.NearbyPlaces = nearbyPlaces;
                    }
                    _cancelToken = new CancellationTokenSource().Token;
                    _renderTask = Task.Factory.StartNew(
                        _ =>
                        {
                            while (!_cancelToken.IsCancellationRequested)
                            {
                                var frameStart = DateTime.Now;
                                repaint();
                                var frameLength = (int)(DateTime.Now - frameStart).TotalMilliseconds;
                                var sleepTime = FRAME_TIME_MILLIS - frameLength;
                                if (sleepTime > 0) Task.Delay(sleepTime).Wait();
                            }
                        },
                        _cancelToken);
                }
                else
                {
                    
                }
            }
        }
    }
}