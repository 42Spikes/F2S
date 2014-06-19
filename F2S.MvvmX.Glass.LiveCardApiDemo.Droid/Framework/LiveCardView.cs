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
using Cirrious.MvvmCross.ViewModels;
using Cirrious.MvvmCross.Views;

namespace F2S.MvvmX.Glass.LiveCardApiDemo.Droid.Views
{
    public class LiveCardView : IMvxView
    {
        public LiveCardView()
        {
        }

        protected virtual void OnViewModelSet()
        {
        }


        private IMvxViewModel _viewModel;
        public Cirrious.MvvmCross.ViewModels.IMvxViewModel ViewModel
        {
            get { return _viewModel; }
            set
            {
                _viewModel = value;
                OnViewModelSet();
            }
        }

        public object DataContext
        {
            get { return _viewModel; }
            set { ViewModel = value as IMvxViewModel; }
        }
    }
}