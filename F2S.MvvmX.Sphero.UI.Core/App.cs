using Cirrious.CrossCore;
using Cirrious.CrossCore.IoC;
using Cirrious.CrossCore.Plugins;
using F2S.MvvmX.Sphero.UI.Core.Interfaces;
using F2S.MvvmX.Sphero.UI.Core.Services;

namespace F2S.MvvmX.Sphero.UI.Core
{
    public class App : Cirrious.MvvmCross.ViewModels.MvxApplication
    {
        public override void Initialize()
        {
            CreatableTypes()
                .EndingWith("Service")
                .AsInterfaces()
                .RegisterAsLazySingleton();
				
            RegisterAppStart<ViewModels.HomeViewModel>();
        }

        public override void LoadPlugins(IMvxPluginManager pluginManager)
        {
            base.LoadPlugins(pluginManager);

            F2S.MvvmX.Plugins.Sphero.PluginLoader.Instance.EnsureLoaded();

            Mvx.RegisterSingleton<ISpheroManager>(new SpheroManager());
            Mvx.RegisterSingleton<ISpheroListService>(new SpheroListService());
        }
    }
}