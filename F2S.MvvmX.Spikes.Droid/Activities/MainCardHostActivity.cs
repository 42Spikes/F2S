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
using Cirrious.CrossCore;
using Cirrious.MvvmCross.Droid.Views;
using Cirrious.MvvmCross.ViewModels;

namespace F2S.MvvmX.Spikes.Droid.Activities
{
    [Activity(Label = "MainCardHostActivity")]
    public class MainCardHostActivity : MvxActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            var presenter = Mvx.Resolve<IMainViewPresenter>();
            presenter.Host = this;

            base.OnCreate(bundle);

            // Create your application here
            var starter = Mvx.Resolve<IMvxAppStart>();
            starter.Start();
        }

        protected override void OnViewModelSet()
        {
            base.OnViewModelSet();
        }
    }
}