using Android.App;
using Android.Content.PM;
using Android.OS;
using Cirrious.CrossCore;
using Cirrious.MvvmCross.Droid.Views;
using Cirrious.MvvmCross.ViewModels;
using F2S.MvvmX.Spikes.Core.ViewModels;
using F2S.MvvmX.Spikes.Droid.Activities;

namespace F2S.MvvmX.Spikes.Droid
{
    [Activity(
		Label = "F2S.MvvmX.Spikes.Droid"
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
            StartActivity( typeof (MainCardHostActivity));
        }

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            //var start = Mvx.Resolve<IMvxAppStart>();
            //start.Start();
        }
    }
}