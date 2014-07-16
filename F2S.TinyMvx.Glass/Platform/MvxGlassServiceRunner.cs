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

namespace F2S.TinyMvx.Glass
{
    public class MvxGlassServiceRunner : MvxServiceRunner
    {
        public override Task<T> StartService<T>()
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

            var context = ((MvxAndroidContext)MvxApplication.CurrentContext).Context;
            context.StartService(
                new Intent(context, typeof (T)));

            return tcs.Task;
        }

        public override void startService()
        {
            throw new NotImplementedException();
        }

        public override Task startServiceAsync()
        {
            throw new NotImplementedException();
        }
    }
}