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

namespace F2S.MvvmX.Samples.Unified.Glass.Framework
{
    public abstract class MvxMessage : IMvxMessage
    {
        public object Sender { get; private set; }

        public MvxMessage(object sender)
        {
            Sender = sender;
        }
    }
}