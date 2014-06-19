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
using F2S.MvvmX.Samples.Unified.Glass.Framework;

namespace F2S.MvvmX.Samples.Unified.Glass.Components.Compass.Services
{
    public class ComposableCompassService : MvxComposableService, IMvxNavigable
    {
        public void ShowViewModel<T>(object paramters = null)
        {
            throw new NotImplementedException();
        }
    }
}