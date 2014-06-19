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
using Cirrious.MvvmCross.Binding.BindingContext;
using Cirrious.MvvmCross.Droid.Views;
using F2S.MvvmX.iOS.SplitView.Core.ViewModels;

namespace F2S.MvvmX.Glass.ApiDemo.Views
{
    [Activity(Label = "MainView")]
    public class MainView : MvxActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Create your application here
        }

        protected override void OnViewModelSet()
        {
            base.OnViewModelSet();

            this.CreateBindingSet<MainView, MvxStaticCardViewModel>();
        }
    }
}