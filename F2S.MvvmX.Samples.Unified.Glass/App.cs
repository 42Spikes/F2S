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

namespace F2S.MvvmX.Samples.Unified.Glass
{
    public class App : MvxApplication<MvxGlassCardPresenter>
    {
        public App()
        {
            
        }

        public override void InitializationComplete()
        {
            base.InitializationComplete();

            try
            {
                
            }
            catch (Exception ex)
            {
            }
        }
    }

    [Service]
    public class unifiedComposite : MvxServiceRunner<ComposableCompassService>
    {
        public override void OnCreate()
        {
            base.OnCreate();
        }

        public override void OnDestroy()
        {
            base.OnDestroy();
        }
    }
}