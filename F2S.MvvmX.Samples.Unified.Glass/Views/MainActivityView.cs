using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using F2S.MvvmX.Samples.Unified.Glass.Components.Compass.Services;
using F2S.MvvmX.Samples.Unified.Glass.Framework;

namespace F2S.MvvmX.Samples.Unified.Glass.Activities
{
    [Activity(Label = "Immersive Glass Example", MainLauncher = true, Icon = "@drawable/icon")]
    [IntentFilter(new[] { "com.google.android.glass.action.VOICE_TRIGGER" })]
    [MetaData("com.google.android.glass.VoiceTrigger", Resource = "@xml/voicetriggerstart")]
    public class MainActivity : MvxActivityView
    {
        public MainActivity()
        {
            
        }

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
        }

        protected override void OnDestroy()
        {
            base.OnDestroy();
        }
    }
}