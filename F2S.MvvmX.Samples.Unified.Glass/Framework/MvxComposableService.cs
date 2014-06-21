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
    public abstract class MvxComposableService : MvxService, IMvxService, IMvxNavigable, IMvxRunnableService
    {
        public virtual void OnCreate()
        {

        }

        public virtual void OnDestroy()
        {

        }

        public virtual StartCommandResult OnStartCommand(Intent intent, StartCommandFlags flags, int startId)
        {
            return StartCommandResult.Sticky;
        }

        public void ShowViewModel<T>(object paramters = null)
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

        public virtual StartCommandResult OnStartCommand(Intent intent, StartCommandFlags flags, int startId)
        {
            return StartCommandResult.Sticky;
        }

        public override IBinder OnBind(Intent intent)
        {
            throw new NotImplementedException();
        }
    }
}