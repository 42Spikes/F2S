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

namespace F2S.TinyMvx
{
    [Activity(Label = "MvxMenuActivity")]
    public class MvxMenuActivity : Activity
    {
        private bool _attachedToWindow;
        private bool _optionsMenuOpen;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Create your application here
        }

        public override void OnAttachedToWindow()
        {
            base.OnAttachedToWindow();
            _attachedToWindow = true;
            OpenOptionsMenu();
        }

        public override void OnDetachedFromWindow()
        {
            base.OnDetachedFromWindow();
            _attachedToWindow = false;
        }

        public override void OpenOptionsMenu()
        {
            if (!_optionsMenuOpen && _attachedToWindow)
            {
                base.OpenOptionsMenu();
            }
        }

        public override bool OnCreateOptionsMenu(IMenu menu)
        {
            //MenuInflater.Inflate(Resource.Menu.compass, menu);
            return true;
        }

        public override bool OnOptionsItemSelected(IMenuItem item)
        {
            switch (item.ItemId)
            {
                //case Resource.Id.read_aloud:
                  //  return true;

                //case Resource.Id.stop:
                    /*
                    _handler.Post(new Action(() =>
                    {
                        StopService(new Intent(this, typeof(CompassService)));
                    }));
                     * */
                    //return true;

                default:
                    return base.OnOptionsItemSelected(item);
            }
        }

        public override void OnOptionsMenuClosed(IMenu menu)
        {
            base.OnOptionsMenuClosed(menu);
            _optionsMenuOpen = false;
            //UnbindService(this);
            Finish();
        }
    }
}