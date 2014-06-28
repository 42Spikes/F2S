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
using TinyMessenger;

namespace F2S.MvvmX.Samples.Unified.Glass.Framework
{
    public class MvxShowViewModelMessage : TinyMessageBase
    {
        public string ViewModelTypeName { get; private set; }
        public object Parameters { get; private set; }

        public MvxShowViewModelMessage(object sender, string viewModelTypeName, object parameters = null)
            :base(sender)
        {
            ViewModelTypeName = viewModelTypeName;
            Parameters = parameters;
        }
    }
}