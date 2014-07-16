using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.Glass.Timeline;
using Android.Graphics;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using F2S.Glass.Framework;

namespace F2S.Glass.Spikes.Minimal.RenderTarget
{
    [Service]
    public class MinimumService : Service
    {
        private LiveCard _card;
        private LiveCardRenderer _renderer;
        private BasicView _view;

        public override IBinder OnBind(Intent intent)
        {
            return null;
        }

        public override StartCommandResult OnStartCommand(Intent intent, StartCommandFlags flags, int startId)
        {
            if (_card == null)
            {
                _card = new LiveCard(this, "theCard");

                _view = new BasicView(this);

                _renderer = new LiveCardRenderer(this);
                _card.SetDirectRenderingEnabled(true).SurfaceHolder.AddCallback(_renderer);
                
                var mi = new Intent(this, typeof (MenuActivity));
                mi.AddFlags(ActivityFlags.NewTask | ActivityFlags.ClearTask);
                _card.SetAction(PendingIntent.GetActivity(this, 0, mi, 0));
                _card.Attach(this);

                _card.Publish(LiveCard.PublishMode.Reveal);

                _renderer.start();
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
        }
    }
}