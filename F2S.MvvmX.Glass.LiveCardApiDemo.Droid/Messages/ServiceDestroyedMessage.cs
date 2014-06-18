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
using F2S.MvvmX.Glass.LiveCardApiDemo.Droid.Services.Compass;

namespace F2S.MvvmX.Glass.LiveCardApiDemo.Droid.Messages
{
    public class ServiceDestroyedMessage : MvxMessage
    {
        public CompassService Service { get { return Sender as CompassService; }}

        public ServiceDestroyedMessage(CompassService service) : base(service)
        {
            
        }
    }
}