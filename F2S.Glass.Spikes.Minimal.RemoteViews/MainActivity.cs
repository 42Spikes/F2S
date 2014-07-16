using System;

using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using F2S.Glass.Spikes.Minimal.RemoteViews;

namespace F2S.Glass.Spikes.Minimal.RemoteView
{
    [Activity(Label = "F2S.Glass.Spikes.Minimal.RemoteView", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            StartService(new Intent(this, typeof (MainService)));
        }
    }
}