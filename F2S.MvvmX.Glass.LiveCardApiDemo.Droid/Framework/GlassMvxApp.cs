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
using Cirrious.CrossCore;
using Cirrious.CrossCore.Droid.Platform;
using Cirrious.MvvmCross.ViewModels;
using F2S.MvvmX.Glass.LiveCardApiDemo.Core;
using F2S.MvvmX.Glass.LiveCardApiDemo.Droid.Bootstrap;
using F2S.MvvmX.Glass.LiveCardApiDemo.Droid.Framework;
using F2S.MvvmX.Glass.LiveCardApiDemo.Droid.Services.Compass;
using F2S.MvvmX.Glass.LiveCardApiDemo.Droid.Services;

namespace F2S.MvvmX.Glass.LiveCardApiDemo.Droid
{
    public class GlassMvxApp : MvxApplication
    {
        public static Activity Trigger { get; set; }
        public static GlassMvxService MainService { get; set; }

        public override void Initialize()
        {
            base.Initialize();
        }
    }

    public class GlassMvxApp<Starter, Runner> : GlassMvxApp 
        where Starter : IMvxAppStart
        where Runner : ServiceRunner
    {
        public override void Initialize()
        {
            base.Initialize();

            CompassViewModelAnnotation.init();

            if (Trigger != null)
            {
                RegisterAppStart(Activator.CreateInstance<Starter>());
                Trigger.StartService(new Intent(Trigger, typeof (Runner)));
            }
        }
    }
}