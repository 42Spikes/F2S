using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.Glass.App;
using Android.Glass.Widget;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using F2S.Glass.ApiDemo.Callbacks;
using F2S.Glass.ApiDemo.Cards;

namespace F2S.Glass.ApiDemo.Touchpad
{
    [Activity(Label = "SelectGestureDemoActivity")]
    public class SelectGestureDemoActivity : Activity, IItemOnClickListenerCallback
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

        protected List<Card> createCards(Context context)
        {
            var cards = new List<Card>();
            cards.Add(new Card(context).SetText("Discrete gestures"));
            cards.Add(new Card(context).SetText("Continuous (scrolling) gestures"));
            return cards;
        }

        public void OnItemClick(AdapterView parent, View view, int position, long id)
        {
            switch (id)
            {
                case 0: StartActivity(new Intent(this, typeof(DiscreteGesturesActivity)));
                    break;
            }
        }
    }
}