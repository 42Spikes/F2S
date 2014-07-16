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
using F2S.Glass.Framework;
using Android.Graphics;

namespace F2S.Glass.Spikes.Minimal.RenderTarget
{
    [Service(Icon = "@drawable/icon")]
    [IntentFilter(new [] { "com.google.android.glass.action.VOICE_TRIGGER" })]
    [MetaData("com.google.android.glass.VoiceTrigger", Resource = "@xml/voicetriggerstart")]
    public class MainService : Service
    {
        private LiveCard _card;
        private LiveCardRenderer _renderer;

        public override IBinder OnBind(Intent intent)
        {
            return null;
        }

        private Handler _handler;
        public override StartCommandResult OnStartCommand(Intent intent, StartCommandFlags flags, int startId)
        {
            if (_card == null)
            {
                _handler = new Handler();

                _card = new LiveCard(this, "theCard");

                _renderer = new LiveCardRenderer(this);
                _card.SetDirectRenderingEnabled(true).SurfaceHolder.AddCallback(_renderer);

                var mi = new Intent(this, typeof(MenuActivity));
                mi.AddFlags(ActivityFlags.NewTask | ActivityFlags.ClearTask);
                _card.SetAction(PendingIntent.GetActivity(this, 0, mi, 0));
                _card.Attach(this);

                _card.Publish(LiveCard.PublishMode.Reveal);

                _renderer.start();

                //_handler.PostDelayed(() => render2(), 1000);
            }
            else
            {
                _card.Navigate();
            }

            return StartCommandResult.Sticky;

        }

        public override void OnDestroy()
        {
            if (_card != null && _card.IsPublished)
            {
                _card.Unpublish();
                _card = null;
            }

            base.OnDestroy();
        }

        private void render()
        {
            /*
            Canvas canvas;
            try
            {
                canvas = _renderer.SurfaceHolder.LockCanvas();
            }
            catch (Exception)
            {
                return;
            }

            if (canvas != null)
            {
                _view.Draw(canvas);
                _renderer.SurfaceHolder.UnlockCanvasAndPost(canvas);
            }
             * */
        }
        private void render2()
        {
            /*
            Canvas canvas;
            try
            {
                canvas = _renderer.SurfaceHolder.LockCanvas();
                if (canvas != null)
                {
                    _view.Draw(canvas);
                    _renderer.SurfaceHolder.UnlockCanvasAndPost(canvas);
                }
            }
            catch (Exception)
            {
                return;
            }
            finally
            {
                _handler.PostDelayed(() => render2(), 1000);
            }
             * */
        }
    }
}