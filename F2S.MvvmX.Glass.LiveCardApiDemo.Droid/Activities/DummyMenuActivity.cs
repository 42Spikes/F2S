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
using F2S.MvvmX.Glass.LiveCardApiDemo.Droid.Services.Compass;

namespace F2S.MvvmX.Glass.LiveCardApiDemo.Droid.Activities
{
    [Activity(Label = "DummyMenuActivity", Theme="@style/MenuTheme")]
    public class DummyMenuActivity : Activity
    {
        public override void OnAttachedToWindow()
        {
            base.OnAttachedToWindow();
            OpenOptionsMenu();
        }

        public override bool OnCreateOptionsMenu(IMenu menu)
        {
            MenuInflater.Inflate(Resource.Menu.DummyMenu, menu);
            return true;
        }

        public override bool OnOptionsItemSelected(IMenuItem item)
        {

            switch (item.ItemId)
            {
                case Resource.Id.Stop:
                    StopService(new Intent(this, typeof(CompassService)));
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