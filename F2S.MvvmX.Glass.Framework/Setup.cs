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
using Cirrious.MvvmCross.Droid.Platform;
using Cirrious.MvvmCross.Droid.Views;
using Cirrious.MvvmCross.ViewModels;
using Org.Apache.Http.Params;

namespace F2S.MvvmX.Glass.Framework
{
    public abstract class Setup : MvxAndroidSetup
    {
        public Setup(Context context) : base(context)
        {
            
        }

        protected override IMvxAndroidViewPresenter CreateViewPresenter()
        {
            var presenter = new LiveCardPresenter();
            Mvx.RegisterSingleton<ILiveCardPresenter>(presenter);
            return presenter;
        }
    }
}