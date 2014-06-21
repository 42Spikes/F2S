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

namespace F2S.Glass.ApiDemo.Cards
{
    [Activity(Label = "BleuImageScroller")]
    public class BleuImageScroller : Activity
    {
        private CardScrollView _scroller;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            _scroller = new CardScrollView(this);
            _scroller.Adapter = new CardAdapter(createCards(this));
            SetContentView(_scroller);

        }

        private List<Card> createCards(Context context)
        {
            var cards = new List<Card>();

            cards.Add(
                new Card(context)
                    .AddImage(Resource.Drawable.bleu1)
                    .SetImageLayout(Card.ImageLayout.Full)
                    .SetText(""));
            cards.Add(
                new Card(context)
                    .AddImage(Resource.Drawable.bleu2)
                    .SetImageLayout(Card.ImageLayout.Full)
                    .SetText(""));
            cards.Add(
                new Card(context)
                    .AddImage(Resource.Drawable.bleu3)
                    .SetImageLayout(Card.ImageLayout.Full)
                    .SetText(""));
            cards.Add(
                new Card(context)
                    .AddImage(Resource.Drawable.bleu4)
                    .SetImageLayout(Card.ImageLayout.Full)
                    .SetText(""));
            cards.Add(
                new Card(context)
                    .AddImage(Resource.Drawable.bleu5)
                    .SetImageLayout(Card.ImageLayout.Full)
                    .SetText(""));

            return cards;
        }


        protected override void OnResume()
        {
            base.OnResume();

            _scroller.Activate();
        }

        protected override void OnPause()
        {
            base.OnPause();

            _scroller.Deactivate();
        }

    }
}