using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.Glass.App;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace F2S.MvvmX.Samples.Unified.Glass.Framework
{
    public class MvxStaticCardView : Card, IMvxView
    {
        public MvxViewModel ViewModel { get; set; }

        public MvxStaticCardView(Context context) : base(context)
        {
            
        }

        public virtual void ViewModelSet()
        {
        }
    }
}