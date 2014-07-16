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

namespace F2S.Glass.Spikes.Stopwatch
{
    public class StopwatchPresenter : GlassPresenter
    {
        private LiveCard _card;
        private ChronometerRenderer _renderer;

        private List<object> _active = new List<object>(); 

        public override void Present(GlassService service)
        {
            base.Present(service);

            if (service.GetType() == typeof (StopwatchService))
            {
                if (_card == null)
                {
                    _card = new LiveCard(service, service.GetType().FullName);
                    _renderer = new ChronometerRenderer(service);
                    _card.SetDirectRenderingEnabled(true).SurfaceHolder.AddCallback(_renderer);

                    var mi = new Intent(service, typeof(MenuActivity));
                    var b = new Bundle();
                    b.PutInt("ResourceID", Resource.Menu.stopwatch);
                    mi.PutExtras(b);
                    mi.AddFlags(ActivityFlags.NewTask | ActivityFlags.ClearTask);

                    _card.SetAction(PendingIntent.GetActivity(service, 0, mi, 0));
                    _card.Attach(service);

                    _card.Publish(LiveCard.PublishMode.Reveal);
                }
                else
                {
                    _card.Navigate();
                }
            }
        }

        public override void ServiceDestroyed(GlassService service)
        {
            if (_card != null && _card.IsPublished)
            {
                _card.Unpublish();
                _card = null;
            }

        }
    }
}