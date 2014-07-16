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
using F2S.Glass.Framework;

namespace F2S.Glass.Spikes.Stopwatch
{
    [Activity(Label = "C# Stopwatch", MainLauncher = true, Icon = "@drawable/icon", Enabled = true)]
    [IntentFilter(new [] { "com.google.android.glass.action.VOICE_TRIGGER" })]
    [MetaData("com.google.android.glass.VoiceTrigger", Resource = "@xml/voice_trigger_start")]
    public class MainActivity : GlassActivity
    {
        public MainActivity() : base(new StopwatchPresenter())
        {
        }

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            StartService(new Intent(this, typeof (StopwatchService)));
        }

        protected override void OnDestroy()
        {
            base.OnDestroy();
        }
    }
}