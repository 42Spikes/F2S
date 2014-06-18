using Android.Content;
using Cirrious.CrossCore;
using Cirrious.CrossCore.Platform;
using Cirrious.MvvmCross.Droid.Platform;
using Cirrious.MvvmCross.Droid.Views;
using Cirrious.MvvmCross.ViewModels;

namespace F2S.MvvmX.Glass.LiveCardApiDemo.Droid
{
    public class Setup : MvxAndroidSetup
    {
        private ApiDemoApp _app;

        public Setup(Context context)
            : base(context)
        {
        }

        protected override IMvxApplication CreateApp()
        {
            return _app = new ApiDemoApp();
        }

        protected override IMvxAndroidViewPresenter CreateViewPresenter()
        {
            var presenter = new LiveCardPresenter();
            Mvx.RegisterSingleton<ILiveCardPresenter>(presenter);
            return presenter;
        }
    }
}