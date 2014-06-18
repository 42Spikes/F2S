using Android.Content;
using Cirrious.CrossCore;
using Cirrious.CrossCore.Platform;
using Cirrious.MvvmCross.Droid.Platform;
using Cirrious.MvvmCross.Droid.Views;
using Cirrious.MvvmCross.ViewModels;
using F2S.MvvmX.Spikes.Droid.Views;

namespace F2S.MvvmX.Spikes.Droid
{
    public class Setup : MvxAndroidSetup
    {
        public Setup(Context applicationContext) : base(applicationContext)
        {
            //Mvx.RegisterSingleton(new MyAppStart<FirstView>());
        }

        protected override IMvxApplication CreateApp()
        {
            return new Core.App();
        }
		
        protected override IMvxTrace CreateDebugTrace()
        {
            return new DebugTrace();
        }

        protected override IMvxAndroidViewPresenter CreateViewPresenter()
        {
            var regionPresenter = new MainViewPresenter();
            Mvx.RegisterSingleton<IMainViewPresenter>(regionPresenter);
            return regionPresenter;
        }
    }
}