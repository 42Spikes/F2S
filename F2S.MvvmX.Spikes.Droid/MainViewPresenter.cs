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
using Cirrious.CrossCore.Exceptions;
using Cirrious.MvvmCross.Droid.Views;
using Cirrious.MvvmCross.Views;
using F2S.MvvmX.Spikes.Droid.Activities;
using Java.Security;

namespace F2S.MvvmX.Spikes.Droid
{
    public interface IMainViewPresenter
    {
        MainCardHostActivity Host { get; set; }
    }

    public class MainViewPresenter : MvxAndroidViewPresenter, IMvxAndroidViewPresenter, IMainViewPresenter
    {
        public MainViewPresenter()
        {
            
        }
        public override void ChangePresentation(Cirrious.MvvmCross.ViewModels.MvxPresentationHint hint)
        {
            base.ChangePresentation(hint);
        }

        public override void Show(Cirrious.MvvmCross.ViewModels.MvxViewModelRequest request)
        {
            if (_host != null)
            {
                var viewFinder = Mvx.Resolve<IMvxViewsContainer>();
                var viewType = viewFinder.GetViewType(request.ViewModelType);
                if (viewType == null) throw new MvxException("Could not find view type for " + request.ViewModelType);
                var view = Activator.CreateInstance(viewType);
                if (view == null) throw new MvxException("Could not load view for " + viewType);
                return;
            }
            base.Show(request);
        }

        private MainCardHostActivity _host;
        public MainCardHostActivity Host
        {
            get { return _host; }
            set { _host = value; }
        }
    }
}