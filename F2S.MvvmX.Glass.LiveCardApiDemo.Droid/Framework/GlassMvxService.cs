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
using Cirrious.MvvmCross.Plugins.Messenger;

namespace F2S.MvvmX.Glass.LiveCardApiDemo.Droid.Framework
{
    public interface IGlassMvxService
    {
        
    }

    [Service]
    public abstract class GlassMvxService : Service, IGlassMvxService
    {
        private IMvxMessenger _messenger;

        public GlassMvxService()
        {
            _messenger = Mvx.Resolve<IMvxMessenger>();
        }

        public void showViewModel<T>()
        {
            _messenger.Publish(new GlassShowViewModelMessage(this, typeof(T)));
        }


        public virtual void attachedRenderer(GlassDirectRenderingCallbackTarget target)
        {
        }
    }

    public interface IMvxServiceComposer
    {
        void OnCreate();
        void OnDestroy();

        StartCommandResult OnStartCommand(Intent intent, StartCommandFlags flags, int startId);

        void ShowViewModel<T>();
    }

    public abstract class MvxServiceComposer : IMvxServiceComposer
    {
        private Dictionary<Type, ManagedCompositeService> _services= new Dictionary<Type, ManagedCompositeService>();

        public ServiceRunner Runner { get; set; }
        private IMvxMessenger _messenger;

        static MvxServiceComposer()
        {
            
        }

        public MvxServiceComposer()
        {
            _messenger = Mvx.Resolve<IMvxMessenger>();
        }

        public virtual void OnCreate()
        {
            var type = this.GetType();
            var generics = type.GetGenericArguments();// GenericTypeArguments;
            var i = (IMvxServiceComposer)this;

            foreach (var generic in generics)
            {
                try
                {
                    var service = Activator.CreateInstance(generic, new [] { i }) as ManagedCompositeService;
                    _services[generic] = service;
                }
                catch (Exception ex)
                {
                    var m = ex.Message;
                }
            }

            _services.Values.ToList().ForEach(s => s.OnCreate());
        }

        public StartCommandResult OnStartCommand(Intent intent, StartCommandFlags flags, int startId)
        {
            _services.Values.ToList().ForEach(s => s.OnStartCommand(intent, flags, startId));
            return StartCommandResult.Sticky;
        }

        public virtual void OnDestroy()
        {
            _services.Values.ToList().ForEach(s => s.OnDestroy());
        }

        public virtual void ShowViewModel<T>()
        {
            _messenger.Publish(new GlassShowViewModelMessage(this, typeof(T)));
        }
    }

    public class MvxServiceComposer<A> : MvxServiceComposer where A : IManagedComposedService
    {

    }

    public class MvxServiceComposer<A, B> : MvxServiceComposer
        where A : IManagedComposedService
        where B : IManagedComposedService
    {

    }
}