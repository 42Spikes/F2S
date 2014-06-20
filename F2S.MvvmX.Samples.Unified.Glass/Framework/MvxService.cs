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
    public interface IMvxRunnableService
    {
        IMvxServiceRunner Runner { get; }
    }


    public interface IMvxService
    {
        void OnCreate();
        void OnDestroy();
        StartCommandResult OnStartCommand(Intent intent, StartCommandFlags flags, int startId);
    }

    public class MvxService : Service, IMvxService, IMvxNavigable
    {
//        private IMvxMessenger _messenger;

        public override IBinder OnBind(Intent intent)
        {
            throw new NotImplementedException();
        }

        public MvxService()
        {
            
        }

        public virtual void ShowViewModel<T>(object paramters = null)
        {
            var messenger = Mvx.Resolve<IMvxMessenger>();
            messenger.Publish(new MvxShowViewModelMessage(this, typeof(T).FullName, paramters));
        }
    }
}