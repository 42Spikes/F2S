using Cirrious.CrossCore.IoC;
//using F2S.MvvmX.Spikes.Droid;
using F2S.MvvmX.Spikes.Core.ViewModels;
using F2S.MvvmX.Spikes.Droid;

namespace F2S.MvvmX.Spikes.Core
{
    public class App : Cirrious.MvvmCross.ViewModels.MvxApplication
    {
        public override void Initialize()
        {
            /*
            CreatableTypes()
                .EndingWith("Service")
                .AsInterfaces()
                .RegisterAsLazySingleton();
			*/	
            RegisterAppStart<ViewModels.FirstViewModel>();
            //RegisterAppStart(new MyAppStart<FirstViewModel>());
        }
    }
}