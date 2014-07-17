using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Util;
using Android.Views;
using Android.Widget;

namespace F2S.Glass.Spikes.Minimal.RenderTarget
{
    public class BasicView : FrameLayout
    {
        private CancellationTokenSource _cts;
        private Task _counter;
        private DateTime _start;
        private int _delay;
        private TextView _tv;

        private Handler _handler = new Handler();

        public BasicView(Context context, string content = "", int delay = 100) : base(context)
        {
            LayoutInflater.From(context).Inflate(Resource.Layout.basic, this);

            _delay = delay;

            _tv = this.FindViewById<TextView>(Resource.Id.hi);
            _tv.Text = content;

            start();
        }

        protected override void OnAttachedToWindow()
        {
            base.OnAttachedToWindow();

            start();
        }

        private void start()
        {
            if (_cts != null) return;
            _start = DateTime.Now;

            _cts = new CancellationTokenSource();
            _counter = Task.Factory.StartNew(doCount);
        }

        protected override void OnDetachedFromWindow()
        {
            base.OnDetachedFromWindow();

            if (_cts != null)
            {
                _cts.Cancel(false);
                _counter.Wait();
            }
        }

        private void doCount()
        {
            while (_cts != null && !_cts.IsCancellationRequested)
            {
                _handler.PostDelayed(() => _tv.Text = (DateTime.Now - _start).TotalMilliseconds.ToString(), 0);

                try
                {
                    Task.Delay(_delay).Wait(_cts.Token);
                }
                catch (Exception)
                {
                }
            }

            _cts = null;
            _counter = null;
        }
    }
}