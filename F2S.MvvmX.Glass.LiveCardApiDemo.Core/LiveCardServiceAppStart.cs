using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Cirrious.MvvmCross.ViewModels;
using F2S.MvvmX.Glass.LiveCardApiDemo.Core.ViewModels;

namespace F2S.MvvmX.Glass.LiveCardApiDemo.Core
{
    public class LiveCardServiceAppStart : MvxNavigatingObject, IMvxAppStart
    {
        private bool _started = false;

        public LiveCardServiceAppStart()
        {
        }

        public void Start(object hint = null)
        {
            if (_started)
            {
                _started = true;
                ShowViewModel<CompassViewModel>();
            }
        }
    }
}
