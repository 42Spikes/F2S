using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.Glass.App;
using Android.Glass.Media;
using Android.Glass.Widget;
using Android.Media;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using F2S.Glass.ApiDemo.Callbacks;
using F2S.Glass.ApiDemo.Cards;

namespace F2S.Glass.ApiDemo
{
    public class CardScrollerActivity : Activity, IItemOnClickListenerCallback
    {
        protected CardScrollView _scroller;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            _scroller = new CardScrollView(this);
            _scroller.Adapter = new CardAdapter(createCards(this));
            SetContentView(_scroller);

            _scroller.OnItemClickListener = new OnItemClickListener(this);
        }

        protected override void OnDestroy()
        {
            base.OnDestroy();
        }

        protected virtual List<Card> createCards(Context context)
        {
            return new List<Card>();
        }

        public virtual void OnItemClick(AdapterView parent, View view, int position, long id)
        {
            onItemClick(id);

            StartActivity(new Intent(this, typeof(BleuImageScroller)));
            var am = (AudioManager)GetSystemService(Context.AudioService);
            am.PlaySoundEffect((SoundEffect)Sounds.Tap);
        }

        protected virtual void onItemClick(long id)
        {
            
        }

        protected override void OnResume()
        {
            base.OnResume();

            _scroller.Activate();
        }

        protected override void OnPause()
        {
            _scroller.Deactivate();

            base.OnPause();
        }

    }
}