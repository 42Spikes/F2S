using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.Glass.Timeline;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace F2S.MvvmX.Samples.Unified.Glass.Framework
{
    public class MvxGlassCardPresenter : MvxMessageBasedPresenter
    {
        public MvxGlassCardPresenter()
        {
        }

        public override void ShowViewModel<T>(object requestor, object parameters)
        {
            showViewModel(requestor, typeof (T), parameters);
        }
    }
}