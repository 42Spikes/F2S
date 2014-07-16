using System;

using Android.App;
using Android.Content;
using Android.Glass.App;
using Android.Glass.Timeline;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using F2S.TinyMvx.Glass.Demo.ViewModels;
using F2S.TinyMvx.Glass.Platform;
using System.Collections.Generic;

namespace F2S.TinyMvx.Glass.Demo.Views
{
    [Activity(Label = "F2S.TinyMvx.Glass.Demo", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainView : MvxGlassCardView
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            ShowViewModel<MainViewModel>(); 
        }
    }
}

