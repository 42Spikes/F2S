using Android.App;
using Android.Content;
using Android.Content.PM;
using Android.OS;
using Cirrious.CrossCore;
using Cirrious.MvvmCross.Droid.Views;
using Cirrious.MvvmCross.ViewModels;
using F2S.MvvmX.Glass.ApiDemo.Views;

namespace F2S.MvvmX.Glass.ApiDemo
{
    [Activity(
    Label = "Splash"
    , MainLauncher = true
    , Icon = "@drawable/icon"
    , Theme = "@style/Theme.Splash"
    , NoHistory = true)]
    //[IntentFilter(new[] { "com.google.android.glass.action.VOICE_TRIGGER" })]
    //[MetaData("com.google.android.glass.VoiceTrigger", Resource = "@xml/use_csharp")]
    public class SplashScreen : MvxSplashScreenActivity
    {
        public SplashScreen()
            : base(Resource.Layout.SplashScreen)
        {
        }
    }
}