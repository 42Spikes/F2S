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
using Cirrious.MvvmCross.Droid.Views;
using Cirrious.MvvmCross.ViewModels;

namespace F2S.MvvmX.Glass.Framework
{
    public interface ILiveCardPresenter
    {
        //MvxCardActivityHost Host { get; set; }
    }

    public class LiveCardPresenter : MvxAndroidViewPresenter, ILiveCardPresenter
    {
        public override void Show(MvxViewModelRequest request)
        {
            base.Show(request);


        }
    }
}