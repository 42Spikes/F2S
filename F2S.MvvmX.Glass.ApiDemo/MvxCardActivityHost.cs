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
using Cirrious.CrossCore;
using Cirrious.MvvmCross.Droid.Views;
using Cirrious.MvvmCross.ViewModels;
using F2S.MvvmX.Glass.ApiDemo.Controls;
using F2S.MvvmX.Glass.ApiDemo.Presenters;
using F2S.MvvmX.Glass.ApiDemo.Views;

namespace F2S.MvvmX.Glass.ApiDemo
{
    [Activity(Label = "MvxCardActivityHost")]
    public class MvxCardActivityHost : Activity
    {
        public Action<MvxCard> CardAttached { get; set; }

        public MvxCardActivityHost()
        {
        }

        protected override void OnCreate(Bundle bundle)
        {
            var presenter = Mvx.Resolve<IMvxCardPresenter>();
            presenter.Host = this;

            base.OnCreate(bundle);

            //var starter = Mvx.Resolve<IMvxAppStart>();
            //starter.Start();
        }
    }
}