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
using Cirrious.MvvmCross.Plugins.Messenger;

namespace F2S.MvvmX.Glass.LiveCardApiDemo.Droid.Framework
{
    public class GlassShowViewModelMessage : MvxMessage
    {
        public Type ViewModelType { get; private set; }
        public GlassMvxService SenderAsService { get { return Sender as GlassMvxService; }}

        public GlassShowViewModelMessage(object sender, Type viewModelType) : base(sender)
        {
            ViewModelType = viewModelType;
        }
    }
}