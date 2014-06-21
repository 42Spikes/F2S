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
using F2S.MvvmX.Samples.Unified.Glass.Components.Compass;
using Java.Security;

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

    public interface IMvxCanAttachRenderer
    {
        void AttachedRenderer(MvxGlassDirectRenderingCallbackTarget renderer);
    }

    public abstract class MvxService : Service, IMvxService, IMvxNavigable, IMvxCanAttachRenderer
    {
        public TaskCompletionSource<MvxService> Created { get; set; }

        public static Dictionary<Type, MvxService> Services = new Dictionary<Type, MvxService>();
 
        public MvxService()
        {
            if (Services.ContainsKey(this.GetType()))
                throw new Exception("Service already created for type: " + this.GetType().FullName);
            Services[this.GetType()] = this;

            Created = new TaskCompletionSource<MvxService>();
        }

        public virtual void ShowViewModel<T>(object paramters = null)
        {
            var messenger = Mvx.Resolve<IMvxMessenger>();
            messenger.Publish(new MvxShowViewModelMessage(this, typeof(T).FullName, paramters));
        }

        public override IBinder OnBind(Intent intent)
        {
            throw new NotImplementedException();
        }

        public override void OnCreate()
        {
            base.OnCreate();

            var messenger = Mvx.SafeResolve<IMvxMessenger>();
            if (messenger != null) messenger.Publish(new MvxServicesStartedMessage(this, this));
        }

        public void AttachedRenderer(MvxGlassDirectRenderingCallbackTarget renderer)
        {
        }
    }
}