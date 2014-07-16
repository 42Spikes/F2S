using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace F2S.TinyMvx
{
    public abstract class MvxPresenter : IMvxPresenter
    {
        public virtual void ShowViewModel<T>(object requestor, object parameters = null)
        {
        }

        public virtual void ShowViewModel(object requestor, MvxViewModel viewModel)
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


        public virtual void ShowViewModel(Type vmt, IMvxView view = null, object parameters = null)
        {
        }
    }
}