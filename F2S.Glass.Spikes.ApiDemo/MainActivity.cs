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
using F2S.Glass.Spikes.ApiDemo.BingImages;
using F2S.Glass.Spikes.ApiDemo.Location;

namespace F2S.Glass.Spikes.ApiDemo
{
    [IntentFilter(new[] { "com.google.android.glass.action.VOICE_TRIGGER" })]
    [MetaData("com.google.android.glass.VoiceTrigger", Resource = "@xml/voicetriggerstart")]
    [Activity(Label = "Do API Demo", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : GlassCardScrollerActivity
    {
        static MainActivity()
        {
            BingImagesActivity.initialize();
        }

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
        }

        protected override List<Card> createCards(Context context)
        {
            return new List<Card>()
            {
                cardFactory(context, "I'm Bleu", "Check me out", Resource.Drawable.bleu1, GlassCardImageLayout.Left),
                cardFactory(context, "Bing Images", "", Resource.Drawable.star, GlassCardImageLayout.Left),
                cardFactory(context, "Location"),
            };
        }

        protected override void onItemClick(long id)
        {
            switch (id)
            {
                case 0:
                    StartActivity(new Intent(this, typeof(ShowBleuActivity)));
                    break;
                case 1:
                    StartActivity(new Intent(this, typeof(BingImagesActivity)));
                    break;
                case 2:
                    StartActivity(new Intent(this, typeof(LocationAndOrientationActivity)));
                    break;
            }
        }
    }
}

