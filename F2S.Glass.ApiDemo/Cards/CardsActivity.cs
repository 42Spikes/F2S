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

namespace F2S.Glass.ApiDemo.Cards
{
    [Activity(Label = "CardsActivity")]
    public class CardsActivity : Activity, IItemOnClickListenerCallback
    {
        private CardScrollView _scroller;

        public CardsActivity()
        {
            
        }

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            _scroller = new CardScrollView(this);
            _scroller.Adapter = new CardAdapter(createCards(this));
            SetContentView(_scroller);

            _scroller.OnItemClickListener = new OnItemClickListener(this);
        }

        private List<Card> createCards(Context context)
        {
            var cards= new List<Card>();
            cards.Add(
                getImagesCard(context)
                    .SetImageLayout(Card.ImageLayout.Full)
                    .SetText("This is full layout image format."));
            cards.Add(
                getImagesCard(context)
                    .SetImageLayout(Card.ImageLayout.Left)
                    .SetText("This is left layout image format. Also, the text size will adjust dynamically."));

            return cards;
        }

        private Card getImagesCard(Context context)
        {
            var card = new Card(context);
            card.AddImage(Resource.Drawable.bleu1);
            card.AddImage(Resource.Drawable.bleu2);
            card.AddImage(Resource.Drawable.bleu3);
            card.AddImage(Resource.Drawable.bleu4);
            card.AddImage(Resource.Drawable.bleu5);
            //card.AddImage(Resource.Drawable.bleu5);
            return card;
        }

        public void OnItemClick(AdapterView parent, View view, int position, long id)
        {
            StartActivity(new Intent(this, typeof (BleuImageScroller)));
            var am = (AudioManager)GetSystemService(Context.AudioService);
            am.PlaySoundEffect((SoundEffect) Sounds.Tap);
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