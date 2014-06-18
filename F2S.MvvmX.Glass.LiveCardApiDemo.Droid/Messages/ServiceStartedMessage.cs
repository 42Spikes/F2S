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
    public class ServiceStartedMessage : MvxMessage
    {
        public CompassService Service { get; private set; }

        public ServiceStartedMessage(CompassService service) : base(service)
        {
            Service = service;
        }
    }
}