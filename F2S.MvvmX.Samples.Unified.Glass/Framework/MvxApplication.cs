using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Java.Security;
using TinyIoC;

namespace F2S.MvvmX.Samples.Unified.Glass.Framework
{
    public interface IMvxApplication
    {
        Task InitializationCompletionTask { get; }

        void Initialize();
        void InitializationComplete();
        void StartService(Intent intent);
        void StartActivity(Intent intent);
    }

    public abstract class MvxApplication : IMvxApplication
    {
        public static Context CurrentContext { get; set; }

        protected static MvxApplication _instance;

        protected static TinyIoCContainer _container = new TinyIoCContainer();
        public static TinyIoCContainer Container { get { return _container; } }

        public static MvxApplication Instance
        {
            get { return _instance; }
        }

        protected static bool _initialized = false;
        public bool IsInitialized { get { return _initialized; } }

        private static object _initLock = new object();

        private static TaskCompletionSource<MvxApplication> _initializationCompletion = new TaskCompletionSource<MvxApplication>();

        public static Task InitializationCompletionTaskStatic
        {
            get { return _initializationCompletion.Task; }
        }
        public Task InitializationCompletionTask
        {
            get { return _initializationCompletion.Task; }
        }

        public MvxApplication()
        {
        }

        public virtual void Initialize()
        {
        }

        public virtual void InitializationComplete()
        {
        }

        public static void verify(IMvxView activity)
        {
            if (_instance == null && !_initialized)
            {
                Task.Factory.StartNew(() => startInitialization(true));
            }
        }

        public static void verify(IMvxService service)
        {
            if (_instance == null && !_initialized)
            {
                Task.Factory.StartNew(() => startInitialization(false));
            }
        }

        public static void startInitialization(bool activityFirst = false)
        {
            if (_initialized) return;

            lock (_initLock)
            {
                try
                {
                    if (_instance != null) return;

                    var assembly = typeof (MvxApplication).Assembly;
                    var appClasses =
                        assembly.DefinedTypes.Where(dt => dt.IsSubclassOf(typeof (MvxApplication)) && !dt.IsAbstract)
                            .ToArray();
                    if (appClasses.Length == 0) throw new Exception("No applicaiton classes defined");
                    if (appClasses.Length > 1) throw new Exception("More than one application class defined");

                    _instance = Activator.CreateInstance(appClasses[0]) as MvxApplication;

                    Mvx.App = _instance;
                    Mvx.Register(_instance);

                    _instance.Initialize();

                    _initialized = true;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    _initializationCompletion.SetResult(_instance);
                    _instance.InitializationComplete();
                }
            }
        }

        public void StartService(Intent intent)
        {
            try
            {
                CurrentContext.StartService(intent);
            }
            catch (Exception ex)
            {
            }
        }

        public void StartActivity(Intent intent)
        {
        }
    }

    public abstract class MvxApplication<Presenter> : MvxApplication where Presenter : IMvxPresenter
    {
        static MvxApplication()
        {
        }

        public MvxApplication()
        {
            if (_instance != null)
            {
                throw new Exception("App already initialized");
            }
            _instance = this;
        }

        public override void Initialize()
        {
            performInitialization();
        }

        protected virtual void performInitialization()
        {
            Mvx.Register<IMvxPresenter>(Activator.CreateInstance<Presenter>());
        }
    }
}