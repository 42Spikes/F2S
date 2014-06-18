using Android.App;
using Android.Content.PM;
using Cirrious.MvvmCross.Droid.Views;

namespace F2S.MvvmX.Glass.App.Droid
{
    [Activity(
		Label = "F2S.MvvmX.Glass.App.Droid"
		, MainLauncher = true
		, Icon = "@drawable/icon"
		, Theme = "@style/Theme.Splash"
		, NoHistory = true
		, ScreenOrientation = ScreenOrientation.Portrait)]
    public class SplashScreen : MvxSplashScreenActivity
    {
        public SplashScreen()
            : base(Resource.Layout.SplashScreen)
        {
        }

        protected override void TriggerFirstNavigate()
        {
            StartActivity(typeof(MainActivity));
        }
    }
}