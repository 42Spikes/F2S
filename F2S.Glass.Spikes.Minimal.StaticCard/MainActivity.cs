using System;

using Android.App;
using Android.Content;
using Android.Glass.App;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace F2S.Glass.Spikes.Minimal.StaticCard
{
    [IntentFilter(new[] { "com.google.android.glass.action.VOICE_TRIGGER" })]
    [MetaData("com.google.android.glass.VoiceTrigger", Resource = "@xml/voicetriggerstart")]
    [Activity(Label = "Min Static Card", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            var card = new Card(this);
            card.SetText("This is Bleu");
            card.SetFootnote("And I am relatively new");

            // this is purely for demo purposes
            var option = 3;
            switch (option)
            {
                case 0:
                {
                    card.SetImageLayout(Card.ImageLayout.Full);
                    card.AddImage(Resource.Drawable.bleu3);
                }
                break;
                
                case 1:
                {
                    card.SetImageLayout(Card.ImageLayout.Left);
                    card.AddImage(Resource.Drawable.bleu3);
                }
                break;
                
                case 2:
                {
                    card.SetImageLayout(Card.ImageLayout.Full);
                    card.AddImage(Resource.Drawable.bleu1);
                    card.AddImage(Resource.Drawable.bleu2);
                    card.AddImage(Resource.Drawable.bleu3);
                    card.AddImage(Resource.Drawable.bleu4);
                    card.AddImage(Resource.Drawable.bleu5);
                }
                break;
                
                case 3:
                {
                    card.SetImageLayout(Card.ImageLayout.Left);
                    card.AddImage(Resource.Drawable.bleu1);
                    card.AddImage(Resource.Drawable.bleu2);
                    card.AddImage(Resource.Drawable.bleu3);
                    card.AddImage(Resource.Drawable.bleu4);
                    card.AddImage(Resource.Drawable.bleu5);
                }
                break;
            }

            SetContentView(card.View);
        }
    }
}

