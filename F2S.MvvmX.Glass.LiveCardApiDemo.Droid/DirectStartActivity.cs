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
using Cirrious.MvvmCross.Droid.Views;
using F2S.MvvmX.Glass.LiveCardApiDemo.Droid.Framework;
using F2S.MvvmX.Glass.LiveCardApiDemo.Droid.Services.Compass;

namespace F2S.MvvmX.Glass.LiveCardApiDemo.Droid
{
    [Activity(
      Label = "DirectStartActivity"
    , MainLauncher = true
    , Icon = "@drawable/icon"
    , Theme = "@style/Theme.Invisible"
    , NoHistory = true)]
    [IntentFilter(new[] { "com.google.android.glass.action.VOICE_TRIGGER" })]
    [MetaData("com.google.android.glass.VoiceTrigger", Resource = "@xml/voicetriggerstart")]

    public class DirectStartActivity : MvxSplashScreenActivity
    {
        public DirectStartActivity()
        {
            GlassMvxApp.Trigger = this;
        }
    }
}