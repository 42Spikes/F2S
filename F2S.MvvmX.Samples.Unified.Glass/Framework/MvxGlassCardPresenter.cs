using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.Glass.Timeline;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace F2S.MvvmX.Samples.Unified.Glass.Framework
{
    public class MvxGlassCardPresenter : MvxMessageBasedPresenter
    {
        public List<MvxActivityView> ViewStack { get; private set; } 
        public MvxActivityView ActiveView { get; private set; }

        public MvxGlassCardPresenter()
        {
            ViewStack = new List<MvxActivityView>();
        }

        public override void ShowViewModel<T>(object requestor, object parameters)
        {
            showViewModel(requestor, typeof (T), parameters);
        }

        public override void ViewCreated(IMvxView view)
        {
            base.ViewCreated(view);

            var av = view as MvxActivityView;
            ActiveView = av;
            ViewStack.Add(av);
        }

        public override void ViewDestroyed(IMvxView view)
        {
            base.ViewDestroyed(view);

            var av = view as MvxActivityView;
            if (ViewStack.Contains(av))
            {
                ViewStack.Remove(av);
            }
        }

        protected override void showViewModel(object requestor, Type viewModelType, object parameters = null)
        {
            base.showViewModel(requestor, viewModelType, parameters);


        }
    }
}