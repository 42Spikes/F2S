using Cirrious.CrossCore.IoC;
using Cirrious.MvvmCross.ViewModels;
using F2S.MvvmX.Glass.LiveCardApiDemo.Core.ViewModels;

namespace F2S.MvvmX.Glass.LiveCardApiDemo.Core
{
    public class App : Cirrious.MvvmCross.ViewModels.MvxApplication
    {
        public App()
        {
        }

        public override void Initialize()
        {
            CreatableTypes()
                .EndingWith("Service")
                .AsInterfaces()
                .RegisterAsLazySingleton();
        }
    }
}