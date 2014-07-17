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
using F2S.Glass.Framework;

namespace F2S.Glass.Spikes.ApiDemo
{
    [Activity(Label = "ShowBleuActivity")]
    public class ShowBleuActivity : GlassCardScrollerActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
        }
        protected override List<Card> createCards(Context context)
        {
            return new List<Card>()
            {
                cardFactory(context, Resource.Drawable.bleu1),
                cardFactory(context, Resource.Drawable.bleu2),
                cardFactory(context, Resource.Drawable.bleu3),
                cardFactory(context, Resource.Drawable.bleu4),
                cardFactory(context, Resource.Drawable.bleu5),
            };
        }
    }
}