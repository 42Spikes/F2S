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

namespace F2S.Glass.Spikes.MinimumLiveCard
{
    public class BasicView : FrameLayout
    {
        public BasicView(Context context) : base(context)
        {
            LayoutInflater.From(context).Inflate(Resource.Layout.basic, this);
        }
    }
}