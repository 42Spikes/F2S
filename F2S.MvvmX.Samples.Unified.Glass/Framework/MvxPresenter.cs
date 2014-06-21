using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Java.Security;

namespace F2S.MvvmX.Samples.Unified.Glass.Framework
{
    public interface IMvxPresenter
    {
        void ShowViewModel<T>(object requestor, object parameters = null);
        void ViewCreated(IMvxView view);
        void ViewDestroyed(IMvxView view);
    }

    public abstract class MvxPresenter : IMvxPresenter
    {
        public Activity CurrentActivity { get; private set; }
        protected void setCurrentActivity(Activity activity)
        {
            CurrentActivity = activity;
        }

        public MvxPresenter()
        {
            var types = this.GetType().Assembly.GetTypes()
                .Where(t =>
                    t.IsSubclassOf(typeof (MvxGlassViewModelAnnotator)) &&
                    !t.IsAbstract).ToList();
            types.ForEach(t => Activator.CreateInstance(t));
        }

        public abstract void ShowViewModel<T>(object requestor, object parameters = null);
        public abstract void ViewCreated(IMvxView view);
        public abstract void ViewDestroyed(IMvxView view);

    }
}