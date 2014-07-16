using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace F2S.TinyMvx.Glass.Core
{
    // represents a UI element that is not an Activity
    public abstract class MvxView : IMvxView
    {
        protected MvxViewModel _vm;
        public MvxViewModel ViewModel
        {
            get { return _vm; }
            set
            {
                if (value != _vm)
                {
                    _vm = value;
                    ViewModelSet();
                }
            }
        }

        public virtual void ViewModelSet()
        {
        }

        public virtual void ShowViewModel<T>(object paramters = null)
        {
            throw new NotImplementedException();
        }

        public virtual void ShowViewModel(object parameters = null)
        {
            throw new NotImplementedException();
        }
    }
}