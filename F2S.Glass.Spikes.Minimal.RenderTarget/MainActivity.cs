using System;

using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace F2S.Glass.Spikes.Minimal.RenderTarget
{
    [Activity(Label = "Main Activity", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            StartService(new Intent(this, typeof (MainService)));
        }
    }
}