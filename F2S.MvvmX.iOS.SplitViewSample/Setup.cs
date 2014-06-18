using Cirrious.CrossCore;
using Cirrious.MvvmCross.Touch.Views;
using Cirrious.MvvmCross.Touch.Views.Presenters;
using F2S.MvvmX.iOS.SplitView.Core;
using F2S.MvvmX.iOS.SplitView.Core.ViewModels;
using MonoTouch.UIKit;
using Cirrious.CrossCore.Platform;
using Cirrious.MvvmCross.ViewModels;
using Cirrious.MvvmCross.Touch.Platform;

namespace F2S.MvvmX.iOS.SplitViewSample
{
    public class Setup : MvxTouchSetup
    {
        private UIWindow _window;

        public Setup(MvxApplicationDelegate applicationDelegate, UIWindow window)
            : base(applicationDelegate, window)
        {
            _window = window;
        }

        protected override Cirrious.MvvmCross.ViewModels.IMvxApplication CreateApp()
        {
            return new App();
        }

        protected override IMvxTouchViewPresenter CreatePresenter()
        {
            if (UIDevice.CurrentDevice.UserInterfaceIdiom == UIUserInterfaceIdiom.Pad)
                return new SplitPresenter(_window);

            return base.CreatePresenter();
        }
    }

    public class SplitPresenter : MvxBaseTouchViewPresenter
    {
        private SplitViewController _svc;

        public SplitPresenter(UIWindow window)
        {
            _svc = new SplitViewController();
            window.RootViewController = _svc;
        }

        public override void Show(Cirrious.MvvmCross.ViewModels.MvxViewModelRequest request)
        {
            var viewController = (UIViewController)Mvx.Resolve<IMvxTouchViewCreator>().CreateView(request);

            if (request.ViewModelType == typeof(FirstViewModel))
                _svc.SetLeft(viewController);
            else
                _svc.SetRight(viewController);
        }

    }

    public class SplitViewController : UISplitViewController
    {
        public SplitViewController()
        {
            this.ViewControllers = new UIViewController[]
                {
                    new UIViewController(), 
                    new UIViewController(), 
                };
        }

        public void SetLeft(UIViewController left)
        {
            this.ViewControllers = new UIViewController[]
                {
                    left,
                    this.ViewControllers[1]
                };
        }

        public void SetRight(UIViewController right)
        {
            this.ViewControllers = new UIViewController[]
                {
                    this.ViewControllers[0],
                    right,
                };
        }
    }
}