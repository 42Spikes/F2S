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
    public interface IMvxView
    {
        MvxViewModel ViewModel { get; set; }

        void ViewModelSet();
    }

    public class MvxActivityView : Activity, IMvxView, IMvxNavigable
    {
        public MvxViewModel ViewModel { get; set; }

        public MvxActivityView()
        {
            MvxApplication.CurrentContext = this;
            MvxApplication.verify(this);
        }

        public void ShowViewModel<T>(object paramters = null)
        {
            throw new NotImplementedException();
        }

        public virtual void ViewModelSet()
        {
        }

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            var presenter = Mvx.SafeResolve<IMvxPresenter>();
            if (presenter != null) presenter.ViewCreated(this);
        }

        protected override void OnDestroy()
        {
            base.OnDestroy();
            var presenter = Mvx.SafeResolve<IMvxPresenter>();
            if (presenter != null) presenter.ViewDestroyed(this);
        }
    }

    public class MvxActivityView<T> : MvxActivityView, IMvxView, IMvxNavigable
    {
        private MvxViewModel _viewModel;
        public MvxViewModel ViewModel
        {
            get { return _viewModel; }
            set
            {
                _viewModel = value;
                ViewModelSet();
            }
        }

        public MvxActivityView()
        {
            //MvxApplication.CurrentContext = this;
            //MvxApplication.verify(this, typeof(T));
        }

        public void ShowViewModel<T>(object paramters = null)
        {
            throw new NotImplementedException();
        }

        public virtual void ViewModelSet()
        {
        }
    }

    public class MvxLiveCardView : LiveCard, IMvxView, IMvxNavigable
    {
        public MvxViewModel ViewModel { get; set; }

        public MvxLiveCardView(Context context, string tag = null) : base(context, tag)
        {
        }

        public void ShowViewModel<T>(object paramters = null)
        {
            throw new NotImplementedException();
        }

        public virtual void ViewModelSet()
        {

        }
    }
}