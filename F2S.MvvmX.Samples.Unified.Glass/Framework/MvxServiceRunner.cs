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
    public interface IMvxServiceRunner
    {
        
    }

    [Service]
    public class MvxServiceRunner : MvxService, IMvxServiceRunner
    {
        public MvxServiceRunner()
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

        public override void OnDestroy()
        {
            base.OnDestroy();
        }
    }

    [Service]
    public class MvxServiceRunner<TheService> : MvxServiceRunner
        where TheService : IMvxService
    {
        protected TheService _service;

        public MvxServiceRunner()
        {
            _service = Activator.CreateInstance<TheService>();
            //_service.Runner = this;
        }

        public override void OnCreate()
        {
            base.OnCreate();

            //GlassMvxApp.MainService = this;

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