using Cirrious.CrossCore.IoC;
using F2S.MvvmX.iOS.SplitView.Core.ViewModels;

namespace F2S.MvvmX.Glass.ApiDemo.Core
{
    public class App : Cirrious.MvvmCross.ViewModels.MvxApplication
    {
        public override void Initialize()
        {
            CreatableTypes()
                .EndingWith("Service")
                .AsInterfaces()
                .RegisterAsLazySingleton();

            //RegisterAppStart<MvxStaticCardViewModel>();
            RegisterAppStart(new MvxStaticCardAppStart());
        }
    }
}