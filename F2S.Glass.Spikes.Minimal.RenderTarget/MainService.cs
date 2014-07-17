using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        private GlassDirectRenderingTarget _renderer;
        private BasicView _view;

        public override IBinder OnBind(Intent intent)
        {
            return null;
        }

        public override StartCommandResult OnStartCommand(Intent intent, StartCommandFlags flags, int startId)
        {
            if (_card == null)
            {
                _view = new BasicView(this, "HIIIIIIIIIII");

                _card = new LiveCard(this, "theCard");

//                _renderer = new LocalDirectRenderer(this, new BasicView(this, "FuBar2"), c => render(c)); //, canvas => render3(canvas));
                _renderer = new GlassDirectRenderingTarget(_view); //, canvas => render3(canvas));
                _card.SetDirectRenderingEnabled(true).SurfaceHolder.AddCallback(_renderer);

                var mi = new Intent(this, typeof(MenuActivity));
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
            if (_renderer != null)
            {
                _renderer.stop();
                _renderer = null;
            }

            if (_card != null && _card.IsPublished)
            {
                _card.Unpublish();
                _card = null;
            }

            base.OnDestroy();
        }

        /*
        private Paint _textPaint = new Paint() { Color = Color.White, TextSize = 32 };

        private void render3(Canvas canvas)
        {
            //_view.Draw(canvas);            
            canvas.DrawRGB(0x00, 0x00, 0xff);
            canvas.DrawText("HI!", 50, 50, _textPaint);

        }

        private void render(Canvas c)
        {
            _view.Draw(c);
        }
        */
    }
}