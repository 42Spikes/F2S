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
using F2S.MvvmX.Glass.LiveCardApiDemo.Core;
using F2S.MvvmX.Glass.LiveCardApiDemo.Droid.Framework;
using F2S.MvvmX.Glass.LiveCardApiDemo.Droid.Services;

namespace F2S.MvvmX.Glass.LiveCardApiDemo.Droid
{
    // cant do this.  I think it's an issue with mvvmcross
    //public class ApiDemoApp : GlassMvxApp<LiveCardServiceAppStart, ServiceRunner<CompositeMvxService<ComposableCompassService>>>
    // have to use the non-generic concrete class

    public class ApiDemoApp : GlassMvxApp<LiveCardServiceAppStart, CompositeServiceRunner>
    {
        public ApiDemoApp()
        {
            
        }
        
        public override void Initialize()
        {
            base.Initialize();
        }
    }
}