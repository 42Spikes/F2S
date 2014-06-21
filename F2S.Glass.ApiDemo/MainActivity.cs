using System.Collections.Generic;
using Android.App;
using Android.Content;
using Android.Glass.Media;
using Android.Glass.Widget;
using Android.Media;
using Android.Runtime;
using Android.Util;
using Android.Views;
using Android.Widget;
using Android.OS;
using Android.Glass.App;
using F2S.Glass.ApiDemo.Callbacks;
using F2S.Glass.ApiDemo.Cards;
using F2S.Glass.ApiDemo.Theming;
using F2S.Glass.ApiDemo.Touchpad;
using Java.Lang;
using String = System.String;

namespace F2S.Glass.ApiDemo
{
    [Activity(Label = "F2S.Glass.ApiDemo", MainLauncher = true, Icon = "@drawable/icon")]
    [IntentFilter(new String[] { "com.google.android.glass.action.VOICE_TRIGGER" })]
    [MetaData("com.google.android.glass.VoiceTrigger", Resource = "@xml/voicetriggerstart")]
    public class MainActivity : Activity, IItemOnClickListenerCallback
    {
        private CardAdapter _adapter;
        private CardScrollView _cardScroller;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            _adapter = new CardAdapter(createCards(this));
            _cardScroller = new CardScrollView(this);
            _cardScroller.Adapter = _adapter;

            SetContentView(_cardScroller);

            setCardScrollerListener();
        }

        protected override void OnDestroy()
        {
            base.OnDestroy();
        }

        private List<Card> createCards(Context context)
        {
            var cards = new List<Card>();
            cards.Add(new Card(context).SetText(Resource.String.text_cards));
            cards.Add(new Card(context).SetText(Resource.String.text_gesture_detector));
            cards.Add(new Card(context).SetText(Resource.String.text_theming));
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
            var soundEffect = Sounds.Tap;

            switch (position)
            {
                case 0:
                    StartActivity(new Intent(this, typeof (CardsActivity)));
                    break;

                case 1:
                    StartActivity(new Intent(this, typeof (SelectGestureDemoActivity)));
                    break;

                case 2:
                    StartActivity(new Intent(this, typeof (ThemingActivity)));
                    break;

                default:
                    soundEffect = Sounds.Error;
                    break;
            }

            // Play sound.
            var am = (AudioManager) GetSystemService(Context.AudioService);
            // wonky cast
            am.PlaySoundEffect((SoundEffect) soundEffect);
        }
    }
}

