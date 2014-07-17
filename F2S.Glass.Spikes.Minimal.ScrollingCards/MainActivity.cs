using System;
using System.Collections.Generic;
using System.Linq;
using Android.App;
using Android.Content;
using Android.Glass.App;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using F2S.Glass.Framework;

namespace F2S.Glass.Spikes.Minimal.ScrollingCards
{
    [IntentFilter(new[] { "com.google.android.glass.action.VOICE_TRIGGER" })]
    [MetaData("com.google.android.glass.VoiceTrigger", Resource = "@xml/voicetriggerstart")]
    [Activity(Label = "Min Scrolling Cards", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : GlassCardScrollerActivity
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

