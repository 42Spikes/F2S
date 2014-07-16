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
using F2S.TinyMvx;

namespace F2S.MvvmX.Samples.Unified.Glass.ViewModels
{
    public class MainViewModel : MvxViewModel, IMvxInitializable
    {
        public string Text { get; set; }
        public string Footer { get; set; }

        public void Init(object parameters)
        {
            var d = parameters as Dictionary<string, string>;
            if (d != null)
            {
                Text = safeGet(d, "Text");
                Footer = safeGet(d, "Footer");
            }
        }

        private string safeGet(Dictionary<string, string> d, string property)
        {
            return d.ContainsKey(property) ? d[property] : "";
        }
    }
}