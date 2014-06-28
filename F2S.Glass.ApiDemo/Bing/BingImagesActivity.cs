using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.Glass.App;
using Android.Glass.Widget;
using Android.Graphics;
using Android.Media;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using F2S.Glass.ApiDemo.Callbacks;
using F2S.Glass.ApiDemo.Cards;

namespace F2S.Glass.ApiDemo.Bing
{
    [Activity(Label = "Bing Images Activity")]
    public class BingImagesActivity : Activity, IItemOnClickListenerCallback
    {
        private CardScrollView _cardScroller;

        public BingImagesActivity()
        {
            
        }

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            _cardScroller = new CardScrollView(this);
            _cardScroller.Adapter = new CardAdapter(createCards(this));
            SetContentView(_cardScroller);
            setCardScrollerListener();
        }

        private List<Card> createCards(Context context)
        {
            var cards = new List<Card>();

            foreach (var image in MainActivity.Bing.Images)
            {
                var bmp =
                    Bitmap.CreateScaledBitmap(
                        Bitmap.CreateBitmap(BitmapFactory.DecodeByteArray(image.Data, 0, image.Data.Length)), 640, 480,
                        false);
                var card = new Card(context);
                //card.SetText("HI!");
                card.AddImage(bmp);
                card.SetText(image.Description);
                card.SetImageLayout(Card.ImageLayout.Full);
                cards.Add(card);
            }

            return cards;
        }

        protected override void OnResume()
        {
            base.OnResume();
            _cardScroller.Activate();
        }

        protected override void OnPause()
        {
            _cardScroller.Deactivate();
            base.OnPause();
        }

        private void setCardScrollerListener()
        {
            _cardScroller.OnItemClickListener = new OnItemClickListener(this);
        }

        public void OnItemClick(AdapterView parent, View view, int position, long id)
        {
        }
    }
}