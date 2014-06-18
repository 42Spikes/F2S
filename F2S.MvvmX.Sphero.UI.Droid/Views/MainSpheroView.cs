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

namespace F2S.MvvmX.Sphero.UI.Droid.Views
{
    [Activity(Label = "MainSpheroView")]
    public class MainSpheroView : MvxActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Create your application here

            SetContentView(Resource.Layout.MainSphero);
        }

        protected override void OnViewModelSet()
        {
            base.OnViewModelSet();
        }
    }
}