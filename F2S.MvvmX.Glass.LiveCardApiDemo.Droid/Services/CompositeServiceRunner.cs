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
using F2S.MvvmX.Glass.LiveCardApiDemo.Droid.Framework;
using F2S.MvvmX.Glass.LiveCardApiDemo.Droid.Services.Compass;

namespace F2S.MvvmX.Glass.LiveCardApiDemo.Droid.Services
{
    [Service]
    public class CompositeServiceRunner : ServiceRunner<MvxServiceComposer<ComposableCompassService>>
    {
        public CompositeServiceRunner()
        {
            
        }
    }
}