using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace F2S.TinyMvx
{
    public abstract class MvxComposableService : IMvxService, IMvxNavigable, IMvxRunnableService
    {
        public virtual void OnCreate()
        {

        }

        public virtual void OnDestroy()
        {

        }

        public virtual void OnCommand()
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

        public IMvxServiceRunner Runner { get; set; }
    }

    public class MvxComposableService<ServiceA, ServiceB> : MvxComposableService
        where ServiceA : IMvxService
        where ServiceB : IMvxService
    {
        public virtual void OnCreate()
        {

        }

        public virtual void OnDestroy()
        {

        }

        public virtual void OnCommand()
        {
        }
    }
}