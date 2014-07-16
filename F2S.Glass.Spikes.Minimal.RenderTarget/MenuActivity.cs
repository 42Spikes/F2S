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

namespace F2S.Glass.Spikes.Minimal.RenderTarget
{
    [Activity(Theme = "@style/MenuTheme")]
    public class MenuActivity : Activity
    {

        public override void OnAttachedToWindow()
        {
            base.OnAttachedToWindow();
            OpenOptionsMenu();
        }

        public override bool OnCreateOptionsMenu(IMenu menu)
        {
            MenuInflater.Inflate(Resource.Menu.StopMenu, menu);
            return true;
        }

        public override bool OnOptionsItemSelected(IMenuItem item)
        {
            // Handle item selection.
            switch (item.ItemId)
            {
                case Resource.Id.Stop:
                    StopService(new Intent(this, typeof(MainService)));
                    return true;
                default:
                    return base.OnOptionsItemSelected(item);
            }
        }

        public override void OnOptionsMenuClosed(IMenu menu)
        {
            Finish();
        }
    }
}