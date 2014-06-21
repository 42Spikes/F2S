using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

    public abstract class MvxServiceRunner : IMvxServiceRunner
    {
        public MvxServiceRunner()
        {
            
        }

        public Task<T> startService<T>() where T : MvxService
        {
            var tcs = new TaskCompletionSource<T>();

            // not necessarily safe right now, as there will not be a failed acknowledgement
            // In process only for now, so ok for the moment...
            var messenger = Mvx.Resolve<IMvxMessenger>();
            Action<MvxServicesStartedMessage> handler;
            handler = m =>
            {
                if (m.Service.GetType() == typeof (T))
                {
                    tcs.SetResult((T) m.Service);
                    //messenger.Unsubscribe(handler);
                }
            };

            messenger.Subscribe(handler);

            MvxApplication.CurrentContext.StartService(
                new Intent(MvxApplication.CurrentContext, typeof (T)));

            return tcs.Task;
        }

        public abstract void startServices();
        public abstract Task startServicesAsync();
    }

    public class MvxServiceRunner<TheService> : MvxServiceRunner
        where TheService : MvxService
    {
        protected TheService _service;

        public MvxServiceRunner()
        {
        }

        public override void startServices()
        {
            try
            {
                startService<TheService>().Wait();
            }
            catch (Exception ex)
            {
            }
        }

        public override Task startServicesAsync()
        {
            return startService<TheService>();
        }
    }
}