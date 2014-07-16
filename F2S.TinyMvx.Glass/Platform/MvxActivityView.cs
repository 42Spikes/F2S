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

namespace F2S.TinyMvx.Glass
{
    public class MvxActivityView : MvxActivity
    {
        public MvxActivityView()
        {
            MvxApplication.verify(this);
            var presenter = Mvx.SafeResolve<IMvxPresenter>();
            if (presenter != null) presenter.ViewInstantiated(this);
        }

        public override void ShowViewModel<T>(object paramters = null)
        {
            var presenter = Mvx.SafeResolve<IMvxPresenter>();
            if (presenter != null) presenter.ShowViewModel<T>(this, paramters);
        }

        public virtual void ViewModelSet()
        {
        }

        public virtual void ViewContentSet(object viewContent)
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

        protected override void OnStart()
        {
            base.OnStart();

            var presenter = Mvx.SafeResolve<IMvxPresenter>();
            if (presenter != null) presenter.ViewActivating(this);
        }

        protected override void OnStop()
        {
            base.OnStop();

            var presenter = Mvx.SafeResolve<IMvxPresenter>();
            if (presenter != null) presenter.ViewDeactivating(this);
        }

        protected override void OnPause()
        {
            base.OnStop();

            var presenter = Mvx.SafeResolve<IMvxPresenter>();
            if (presenter != null) presenter.ViewPaused(this);
        }

        protected override void OnResume()
        {
            base.OnStop();

            var presenter = Mvx.SafeResolve<IMvxPresenter>();
            if (presenter != null) presenter.ViewResumed(this);
        }

        protected override void OnRestart()
        {
            base.OnStop();

            var presenter = Mvx.SafeResolve<IMvxPresenter>();
            if (presenter != null) presenter.ViewRestarted(this);
        }
    }

    public class MvxActivityView<T> : MvxActivityView
    {
        public MvxActivityView()
        {
        }

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            ShowViewModel<T>();
        }

        public override void ShowViewModel<T>(object parameters = null)
        {
            Mvx.Resolve<IMvxPresenter>(p => p.ShowViewModel<T>(parameters));
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

        public void ShowViewModel(object paramters = null)
        {
            throw new NotImplementedException();
        }
        public virtual void ViewModelSet()
        {

        }
    }
}