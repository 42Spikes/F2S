using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using F2S.TinyMvx.Glass;
using F2S.TinyMvx.Glass.Core;
using TinyIoC;
using TinyMessenger;

namespace F2S.TinyMvx
{
    public abstract class MvxApplication : IMvxApplication
    {
        protected MvxContext _context;

        // this needs a ton of refactoring
        public static MvxContext CurrentContext { get; set; }

        protected static TinyIoCContainer _container = new TinyIoCContainer();
        public static TinyIoCContainer Container { get { return _container; } }

        protected static MvxApplication _instance;
        public static MvxApplication Instance
        {
            get { return _instance; }
        }

        protected static Dictionary<Type, IMvxService> _runningServices = new Dictionary<Type, IMvxService>();
        public static Dictionary<Type, IMvxService> RunningServices { get { return _runningServices; } }


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

        public static void verify(IMvxView view, Type viewModel = null)
        {
            verifyApp(view);

            if (_instance == null && !_initialized)
            {
                Task.Factory.StartNew(() => startInitialization(view, viewModel));
            }
        }

        public static void verify(IMvxService service)
        {
            verifyApp(service);

            if (_instance == null && !_initialized)
            {

                Task.Factory.StartNew(() => startInitialization()).ContinueWith(_ => _instance.track(service));
            }
            else
            {
                _instance.track(service);
            }
        }

        private static void verifyApp(object viewOrService)
        {
            if (_instance != null) return;

            var assembly = viewOrService.GetType().Assembly;
            //var assembly = typeof(MvxApplication).Assembly;

            var appClasses =
                assembly.DefinedTypes.Where(dt => dt.IsSubclassOf(typeof(MvxApplication)) && !dt.IsAbstract)
                    .ToArray();
            if (appClasses.Length == 0) throw new Exception("No application classes defined");
            if (appClasses.Length > 1) throw new Exception("More than one application class defined");

            try
            {
                _instance = Activator.CreateInstance(appClasses[0]) as MvxApplication;
            }
            catch (Exception ex)
            {
            }

            Mvx.App = _instance;
            Mvx.Register(_instance);

            _instance.firstChanceInitialize();
        }

        public virtual void firstChanceInitialize()
        {
            initializeAnnotations();
            registerViewModels();
            createMessenger();
            createViewLocator();
            createPresenter();
        }

        protected virtual void initializeAnnotations()
        {
            MvxAnnotationsManager.initialize();
        }

        protected virtual void registerViewModels()
        {
            var viewModelTypes = this.GetType().Assembly.DefinedTypes.Where(
                t => t.IsSubclassOf(typeof (MvxViewModel)) && !t.IsAbstract).ToList();
            viewModelTypes.ForEach(MvxPropertyManager.register);
        }

        protected virtual void createMessenger()
        {
            Mvx.Register<ITinyMessengerHub>(new TinyMessengerHub());
        }

        protected virtual void createViewLocator()
        {
            Mvx.Register<IMvxViewLocator>(new MvxViewLocator());
        }

        protected virtual void createPresenter()
        {
            
        }

        private void track(IMvxService service)
        {
            _runningServices.Add(service.GetType(), service);
        }

        public void untrack(IMvxService service)
        {
            _runningServices.Remove(service.GetType());
        }

        public static void startInitialization(IMvxView view = null, Type viewModelType = null)
        {
            if (_initialized) return;

            lock (_initLock)
            {
                try
                {
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

        public abstract void StartService(MvxStartServiceCommand command);
        //public abstract void StartService<T>(MvxStartServiceCommand command) where T : IMvxService;

        public abstract void ShowView(MvxShowViewCommand command);
    }

    public abstract class MvxApplication<Presenter, ServiceRunner> : 
        MvxApplication 
            where Presenter : IMvxPresenter
            where ServiceRunner : MvxServiceRunner
    {
        private MvxServiceRunner _runner;

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

            _runner = Activator.CreateInstance<ServiceRunner>();
        }

        public override void firstChanceInitialize()
        {
            // runs on UI thread
            base.firstChanceInitialize();
        }

        public override void Initialize()
        {
            // runs on background thread
            performInitialization();
            startServices();
            doInitialNavigation();
        }

        protected virtual void performInitialization()
        {
            //createMessenger(); // must go before presenter
            //createPresenter();
        }

        protected override void createPresenter()
        {
            try
            {
                var t = typeof (Presenter);
                var n = t.Name;
                var presenter = Activator.CreateInstance<Presenter>();
                Mvx.Register<IMvxPresenter>(presenter);
            }
            catch (Exception ex)
            {
            }
        }

        protected virtual void createMessenger()
        {
            base.createMessenger();
        }

        protected virtual void startServices()
        {
            _runner.startService();
        }

        protected virtual void doInitialNavigation()
        {
        }

        public override void StartService(MvxStartServiceCommand command)
        {
            throw new NotImplementedException();
        }

        public override void ShowView(MvxShowViewCommand command)
        {
            throw new NotImplementedException();
        }
    }
}