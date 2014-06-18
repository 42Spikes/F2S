using System.Drawing;
using Cirrious.MvvmCross.Binding.BindingContext;
using Cirrious.MvvmCross.Touch.Views;
using F2S.MvvmX.iOS.SplitView.Core.ViewModels;
using MonoTouch.ObjCRuntime;
using MonoTouch.UIKit;
using MonoTouch.Foundation;

namespace F2S.MvvmX.iOS.SplitViewSample.Views
{
    [Register("FirstView")]
    public class FirstView : MvxViewController
    {
        public override void ViewDidLoad()
        {
            View = new UIView() { BackgroundColor = UIColor.White };
            base.ViewDidLoad();

            var b1 = new UIButton(UIButtonType.RoundedRect);
            b1.Frame = new RectangleF(10, 10, 300, 40);
            b1.SetTitle("Blue", UIControlState.Normal);
            Add(b1);

            var b2 = new UIButton(UIButtonType.RoundedRect);
            b2.Frame = new RectangleF(10, 50, 300, 40);
            b2.SetTitle("Red", UIControlState.Normal);
            Add(b2);

            var set = this.CreateBindingSet<FirstView, FirstViewModel>();
            set.Bind(b1).To(vm => vm.BlueCommand);
            set.Bind(b2).To(vm => vm.RedCommand);
            set.Apply();
        }
    }

    [Register("RedView")]
    public class RedView : MvxViewController
    {
        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            View.BackgroundColor = UIColor.Red;
        }
    }

    [Register("BlueView")]
    public class BlueView : MvxViewController
    {
        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            View.BackgroundColor = UIColor.Blue;
        }
    }
}