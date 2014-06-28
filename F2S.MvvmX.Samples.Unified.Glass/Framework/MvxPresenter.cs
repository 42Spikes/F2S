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
        void ViewActivating(IMvxView view);
        void ViewDeactivating(IMvxView view);
        void ViewCreated(IMvxView view);
        void ViewDestroyed(IMvxView view);
        void ViewInstantiated(IMvxView view);
        void ViewPaused(IMvxView view);
        void ViewResumed(IMvxView view);
        void ViewRestarted(IMvxView view);
    }

    public abstract class MvxPresenter : IMvxPresenter
    {
        public MvxPresenter()
        {
            var types = this.GetType().Assembly.GetTypes()
                .Where(t =>
                    t.IsSubclassOf(typeof (MvxGlassViewModelAnnotator)) &&
                    !t.IsAbstract).ToList();
            types.ForEach(t => Activator.CreateInstance(t));
        }

        public virtual void ShowViewModel<T>(object requestor, object parameters = null)
        {
        }

        public virtual void ViewCreated(IMvxView view)
        {
        }

        public virtual void ViewDestroyed(IMvxView view)
        {
        }

        public virtual void ViewActivating(IMvxView view)
        {
        }

        public virtual void ViewDeactivating(IMvxView view)
        {
        }

        public virtual void ViewInstantiated(IMvxView view)
        {

        }
        public virtual void ViewPaused(IMvxView view)
        {

        }
        public virtual void ViewResumed(IMvxView view)
        {

        }
        public virtual void ViewRestarted(IMvxView view)
        {

        }
    }
}