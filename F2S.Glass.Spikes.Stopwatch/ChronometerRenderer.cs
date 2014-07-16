using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.Graphics;
using Android.OS;
using Android.Runtime;
using Android.Util;
using Android.Views;
using Android.Widget;
using Android.Glass.Timeline;

namespace F2S.Glass.Spikes.Stopwatch
{
    public class ChronometerRenderer : Java.Lang.Object, IDirectRenderingCallback
    {
        private static string TAG = typeof (ChronometerRenderer).Name;
        private static int COUNT_DOWN_VALUE = 5;

        private CountdownView _countDownView;
        private ChronometerView _chronometerView;

        private ISurfaceHolder _holder;
        private bool _countDownDone;
        private bool _renderingPaused;

        public ChronometerRenderer(Context context) : 
            this(new CountdownView(Resource.Layout.card_countdown, context), 
                 new ChronometerView(Resource.Layout.card_chronometer, context))
        {
        }

        public ChronometerRenderer(CountdownView countDownView, ChronometerView chronometerView)
        {
            _countDownView = countDownView;
            _countDownView.CountdownTimeSeconds = COUNT_DOWN_VALUE;
            _countDownView.Tick += _countDownView_Tick;
            _countDownView.Finished += _countdownView_Finished;

            _chronometerView = chronometerView;
            _chronometerView.Changed += _chronometerView_Changed;
        }

        #region IDirectRenderingCallback

        public void SurfaceChanged(ISurfaceHolder holder, Android.Graphics.Format format, int width, int height)
        {
            var measuredWidth = View.MeasureSpec.MakeMeasureSpec(width, MeasureSpecMode.Exactly);
            var measuredHeight = View.MeasureSpec.MakeMeasureSpec(height, MeasureSpecMode.Exactly);

            _countDownView.Measure(measuredWidth, measuredHeight);
            _countDownView.Layout(0, 0, _countDownView.MeasuredWidth, _countDownView.MeasuredHeight);

            _chronometerView.Measure(measuredWidth, measuredHeight);
            _chronometerView.Layout(0, 0, _chronometerView.MeasuredWidth, _chronometerView.MeasuredHeight);
        }

        public void SurfaceCreated(ISurfaceHolder holder)
        {
            _renderingPaused = false;
            _holder = holder;
            updateRenderingState();
        }

        public void RenderingPaused(ISurfaceHolder holder, bool paused)
        {
            _renderingPaused = paused;
            updateRenderingState();
        }

        public void SurfaceDestroyed(ISurfaceHolder holder)
        {
            _holder = null;
            updateRenderingState();
        }

        #endregion

        private void _countdownView_Finished(object sender, EventArgs eventArgs)
        {
            _countDownDone = true;
            _chronometerView.setBaseMillis(SystemClock.ElapsedRealtime());
            updateRenderingState();
        }

        void _countDownView_Tick(object sender, EventArgs e)
        {
            if (_holder != null)
            {
                draw(_countDownView);
            }
        }
        
        void _chronometerView_Changed(object sender, EventArgs e)
        {
            if (_holder != null)
                draw(_chronometerView);
        }

        private void updateRenderingState()
        {
            if (_holder != null && !_renderingPaused)
            {
                if (_countDownDone)
                {
                    _chronometerView.start();
                }
                else
                {
                    _countDownView.start();
                }
            }
            else
            {
                _chronometerView.stop();
            }
        }

        private void draw(View view)
        {
            Canvas canvas;
            try
            {
                canvas = _holder.LockCanvas();
            }
            catch (Exception e)
            {
                Log.Error(TAG, "Unable to lock canvas: " + e);
                return;
            }
            if (canvas != null)
            {
                view.Draw(canvas);
                _holder.UnlockCanvasAndPost(canvas);
            }
        }
    }
}