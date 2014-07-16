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
using F2S.TinyMvx.Glass;
using Java.Security;
using TinyMessenger;

namespace F2S.TinyMvx.Glass
{
    public abstract class MvxAndroidService : Service, IMvxService, IMvxCanAttachRenderer
    {
        public TaskCompletionSource<IMvxService> Created { get; set; }

        public static Dictionary<Type, IMvxService> Services = new Dictionary<Type, IMvxService>();
 
        public MvxAndroidService()
        {
            if (Services.ContainsKey(this.GetType()))
                throw new Exception("Service already created for type: " + this.GetType().FullName);
            Services[this.GetType()] = this;

            Created = new TaskCompletionSource<IMvxService>();
        }

        public virtual void OnCommand()
        {
            
        }

        public virtual void ShowViewModel<T>(object paramters = null)
        {
            //var messenger = Mvx.Resolve<IMvxMessenger>();
            //messenger.Publish(new MvxShowViewModelMessage(this, typeof(T).FullName, paramters));
            var messenger = Mvx.Resolve<ITinyMessengerHub>();
            messenger.Publish(new MvxShowViewModelMessage(this, typeof(T).FullName, paramters));
        }

        public override IBinder OnBind(Intent intent)
        {
            throw new NotImplementedException();
        }

        public override void OnCreate()
        {
            var messenger = Mvx.SafeResolve<IMvxMessenger>();
            if (messenger != null) messenger.Publish(new MvxServicesStartedMessage(this, this));
        }

        public void AttachedRenderer(MvxGlassDirectRenderingCallbackTarget renderer)
        {
        }
    }
}