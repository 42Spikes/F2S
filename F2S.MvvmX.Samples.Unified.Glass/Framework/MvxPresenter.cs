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
using Java.Security;

namespace F2S.MvvmX.Samples.Unified.Glass.Framework
{
    public interface IMvxPresenter
    {
        void ShowViewModel<T>(object requestor, object parameters = null);
    }

    public abstract class MvxPresenter : IMvxPresenter
    {
        public MvxPresenter()
        {
            
        }

        public abstract void ShowViewModel<T>(object requestor, object parameters = null);
    }
}