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
using Java.Security;

namespace F2S.MvvmX.Samples.Unified.Glass.Framework
{
    public interface IMvxMessenger
    {
        void Publish<T>(T message) where T : IMvxMessage;
        void Subscribe<T>(Action<T> handler) where T : IMvxMessage;
    }
}