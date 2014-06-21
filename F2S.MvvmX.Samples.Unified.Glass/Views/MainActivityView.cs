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
using F2S.MvvmX.Samples.Unified.Glass.Components.Compass.Services;
using F2S.MvvmX.Samples.Unified.Glass.Framework;
using F2S.MvvmX.Samples.Unified.Glass.Services;
using F2S.MvvmX.Samples.Unified.Glass.ViewModels;

namespace F2S.MvvmX.Samples.Unified.Glass.Activities
{
    [Activity(Label = "Immersive Glass Example", MainLauncher = true, Icon = "@drawable/icon", NoHistory=true)]
    //[IntentFilter(new[] { "com.google.android.glass.action.VOICE_TRIGGER" })]
    //[MetaData("com.google.android.glass.VoiceTrigger", Resource = "@xml/voicetriggerstart")]
    //[MvxStartActivity]

    public class MainActivity : Activity // MvxActivityView<MainViewModel>
    {
        public static MainActivity Active { get; set; }

        public MainActivity()
        {
            Active = this;
        }

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            var card2 = new Card(this);
            card2.SetText("fubar");
            card2.SetFootnote("Just scanned!");
            SetContentView(card2.View);
        }

        protected override void OnDestroy()
        {
            base.OnDestroy();
        }
    }
}