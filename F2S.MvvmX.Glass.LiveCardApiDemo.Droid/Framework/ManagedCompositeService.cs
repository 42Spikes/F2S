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

namespace F2S.MvvmX.Glass.LiveCardApiDemo.Droid.Framework
{
    public interface IManagedComposedService
    {
        void OnCreate();
        void OnDestroy();
        StartCommandResult OnStartCommand(Intent intent, StartCommandFlags flags, int startId);
    }

    public abstract class ManagedCompositeService : IManagedComposedService
    {
        public IMvxServiceComposer ServiceComposer { get; private set; }

        public ManagedCompositeService(IMvxServiceComposer serviceComposer)
        {
            ServiceComposer = serviceComposer;
        }

        public virtual void OnCreate()
        {
        }

        public virtual StartCommandResult OnStartCommand(Intent intent, StartCommandFlags flags, int startId)
        {
            return StartCommandResult.Sticky;
        }

        public virtual void OnDestroy()
        {
            
        }
    }
}