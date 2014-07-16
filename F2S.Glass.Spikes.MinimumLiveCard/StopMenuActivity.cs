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
    [Activity(Theme = "@style/MenuTheme")]
    public class StopMenuActivity : Activity
    {
        public override void OnAttachedToWindow()
        {
            base.OnAttachedToWindow();

            OpenOptionsMenu();
        }

        public override bool OnCreateOptionsMenu(IMenu menu)
        {
            MenuInflater.Inflate(Resource.Menu.stopmenu, menu);
            return true;
        }

        public override bool OnOptionsItemSelected(IMenuItem item)
        {
            return base.OnOptionsItemSelected(item);
        }

        public override void OnOptionsMenuClosed(IMenu menu)
        {
            Finish();
        }
    }
}