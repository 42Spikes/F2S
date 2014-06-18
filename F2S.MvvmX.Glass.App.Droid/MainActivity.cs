﻿using System;

using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Cirrious.CrossCore;
using Cirrious.MvvmCross.Droid.Views;
using Cirrious.MvvmCross.ViewModels;

namespace F2S.MvvmX.Glass.App.Droid
{
    [Activity(Label = "F2S.MvvmX.Glass.App.Droid", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : MvxActivity
    {
        int count = 1;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            // Get our button from the layout resource,
            // and attach an event to it
            Button button = FindViewById<Button>(Resource.Id.MyButton);

            button.Click += delegate { button.Text = string.Format("{0} clicks!", count++); };

            var starter = Mvx.Resolve<IMvxAppStart>();
            starter.Start();
        }
    }
}
