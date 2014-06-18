using Android.Content;
using Android.Util;
using Cirrious.CrossCore;
using Cirrious.CrossCore.Platform;
using Cirrious.MvvmCross.Droid.Platform;
using Cirrious.MvvmCross.Droid.Views;
using Cirrious.MvvmCross.ViewModels;
using F2S.MvvmX.Glass.ApiDemo.Presenters;

namespace F2S.MvvmX.Glass.ApiDemo
{
    public class Setup : MvxAndroidSetup
    {
        public Setup(Context applicationContext) : base(applicationContext)
        {
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
            //return base.CreateViewPresenter();
            var presenter = new MvxCardPresenter();
            Mvx.RegisterSingleton<IMvxCardPresenter>(presenter);
            return presenter;
        }
    }
}