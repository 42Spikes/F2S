using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.Glass.App;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace F2S.Glass.ApiDemo.Theming
{
    [Activity(Label = "ThemingActivity")]
    public class ThemingActivity : CardScrollerActivity
    {
        public ThemingActivity()
        {
        }

        protected override List<Card> createCards(Context context)
        {
            var cards = new List<Card>();
            cards.Add(new Card(context).SetText("Discrete gestures"));
            cards.Add(new Card(context).SetText("Continuous (scrolling) gestures"));
            return cards;
        }

        protected override void onItemClick(long id)
        {
            switch (id)
            {
                
            }
        }
    }
}