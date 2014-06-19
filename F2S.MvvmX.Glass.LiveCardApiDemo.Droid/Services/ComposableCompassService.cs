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
using F2S.MvvmX.Glass.LiveCardApiDemo.Droid.Framework;

namespace F2S.MvvmX.Glass.LiveCardApiDemo.Droid.Services
{
    public interface ICompassService
    {
        
    }

    public class ComposableCompassService : ManagedCompositeService, ICompassService
    {
        public ComposableCompassService(IMvxServiceComposer composer)
            : base(composer)
        {
        }

        public ComposableCompassService() : base(null)
        {
            
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
}