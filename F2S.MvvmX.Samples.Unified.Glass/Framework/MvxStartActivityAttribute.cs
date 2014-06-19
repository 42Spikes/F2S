using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace F2S.MvvmX.Samples.Unified.Glass.Framework
{
    [AttributeUsage(AttributeTargets.Class)]
    public class MvxStartActivityAttribute : Attribute
    {
        public static bool has(object o)
        {
            return o.GetType().GetCustomAttributes(typeof (MvxStartActivityAttribute), true).Length > 0;
        }
    }
}