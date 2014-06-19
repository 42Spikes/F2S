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
using F2S.MvvmX.Samples.Unified.Glass.Components.Compass.Services;
using F2S.MvvmX.Samples.Unified.Glass.Framework;
using F2S.MvvmX.Samples.Unified.Glass.ViewModels;

namespace F2S.MvvmX.Samples.Unified.Glass.Activities
{
    [Activity(Label = "Immersive Glass Example", MainLauncher = true, Icon = "@drawable/icon")]
    [IntentFilter(new[] { "com.google.android.glass.action.VOICE_TRIGGER" })]
    [MetaData("com.google.android.glass.VoiceTrigger", Resource = "@xml/voicetriggerstart")]
    [MvxStartActivity]

    public class MainActivity : MvxActivityView<MainViewModel>
    {
        public MainActivity()
        {
        }

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            StartService(
                new Intent(
                    MvxApplication.CurrentContext,
                    typeof (unifiedComposite)));
        }

        protected override void OnDestroy()
        {
            base.OnDestroy();
        }
    }
}