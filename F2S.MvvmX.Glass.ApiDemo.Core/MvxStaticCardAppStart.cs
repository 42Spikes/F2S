using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cirrious.MvvmCross.ViewModels;
using F2S.MvvmX.Glass.ApiDemo.Core.ViewModels;
using F2S.MvvmX.iOS.SplitView.Core.ViewModels;

namespace F2S.MvvmX.Glass.ApiDemo.Core
{
    public class MvxStaticCardAppStart : MvxNavigatingObject, IMvxAppStart
    {
        public void Start(object hint = null)
        {
            ShowViewModel<AccelerometerViewModel>();
        }
    }
}
