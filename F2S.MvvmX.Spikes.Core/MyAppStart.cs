using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Cirrious.MvvmCross.ViewModels;
using F2S.MvvmX.Spikes.Core.ViewModels;

namespace F2S.MvvmX.Spikes.Droid
{
    public class MyAppStart<T> : MvxNavigatingObject, IMvxAppStart
        where T : IMvxViewModel
    {
        public void Start(object hint = null)
        {
            ShowViewModel<T>();
        }
    }
}