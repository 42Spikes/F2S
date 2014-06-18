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

namespace F2S.MvvmX.Glass.Compass.Droid
{
    [Activity(Label = "DirectStartActivity", MainLauncher = true)]
    public class DirectStartActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Create your application here

            StartService(new Intent(this, typeof (CompassService)));
        }

        protected override void OnDestroy()
        {
            base.OnDestroy();
        }
    }
}