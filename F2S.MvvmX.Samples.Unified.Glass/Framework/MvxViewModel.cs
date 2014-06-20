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

namespace F2S.MvvmX.Samples.Unified.Glass.Framework
{
    public interface IMvxViewModel
    {
        void ShowViewModel<T>(object parameters = null);
    }

    public class MvxViewModel : IMvxViewModel
    {
        public void ShowViewModel<T>(object parameters = null)
        {
            var presenter = Mvx.Resolve<IMvxPresenter>();
            presenter.ShowViewModel<T>(this);
        }
    }
}