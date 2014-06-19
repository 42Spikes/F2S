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
using F2S.MvvmX.Glass.LiveCardApiDemo.Droid.Services.Compass;

namespace F2S.MvvmX.Glass.LiveCardApiDemo.Droid.Framework
{
    [Service]
    public class ServiceRunner : GlassMvxService
    {
        public ServiceRunner()
        {
            
        }
        public override IBinder OnBind(Intent intent)
        {
            throw new NotImplementedException();
        }

        public override void OnCreate()
        {
            base.OnCreate();
        }

        public override StartCommandResult OnStartCommand(Intent intent, StartCommandFlags flags, int startId)
        {
            return base.OnStartCommand(intent, flags, startId);
        }

        public override void OnDestroy()
        {
            base.OnDestroy();
        }
    }

    public class ServiceRunner<TheService> : ServiceRunner
        where TheService : MvxServiceComposer
    {
        protected TheService _service;

        public ServiceRunner()
        {
            _service = Activator.CreateInstance<TheService>();
            _service.Runner = this;
        }

        public override void OnCreate()
        {
            base.OnCreate();

            GlassMvxApp.MainService = this;

            _service.OnCreate();
        }

        public override StartCommandResult OnStartCommand(Intent intent, StartCommandFlags flags, int startId)
        {
            return _service.OnStartCommand(intent, flags, startId);
        }

        public override void OnDestroy()
        {
            base.OnDestroy();

            _service.OnDestroy();
        }
    }
}