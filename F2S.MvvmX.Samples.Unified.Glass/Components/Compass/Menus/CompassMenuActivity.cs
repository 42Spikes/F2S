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
using F2S.MvvmX.Samples.Unified.Glass.Components.Compass.Services;

namespace F2S.MvvmX.Samples.Unified.Glass.Components.Compass.Menus
{
    [Activity(Label = "CompassMenuActivity")]
    public class CompassMenuActivity : Activity, IServiceConnection
    {
        private Handler _handler = new Handler();
        private CompassServiceBinder _compassServiceBinder;
        private bool _attachedToWindow;
        private bool _optionsMenuOpen;

        public void OnServiceConnected(ComponentName name, IBinder service)
        {
            if (service is CompassServiceBinder)
            {
                _compassServiceBinder = (CompassServiceBinder)service;
                OpenOptionsMenu();
            }
        }

        public void OnServiceDisconnected(ComponentName name)
        {
        }

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Create your application here
            //BindService(new Intent(this, typeof (CompassService)), this, 0);
            BindService(new Intent(this, typeof(CompassService)), this, Bind.AutoCreate);
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
            if (!_optionsMenuOpen && _attachedToWindow && _compassServiceBinder != null)
            {
                base.OpenOptionsMenu();
            }
        }

        public override bool OnCreateOptionsMenu(IMenu menu)
        {
            MenuInflater.Inflate(Resource.Menu.compass, menu);
            return true;
        }

        public override bool OnOptionsItemSelected(IMenuItem item)
        {
            switch (item.ItemId)
            {
                case Resource.Id.read_aloud:
                    _compassServiceBinder.readHeadingAloud();
                    return true;

                case Resource.Id.stop:
                    _handler.Post(new Action(() =>
                    {
                        StopService(new Intent(this, typeof (CompassService)));
                    }));
                    return true;

                default:
                    return base.OnOptionsItemSelected(item);
            }
        }

        public override void OnOptionsMenuClosed(IMenu menu)
        {
            base.OnOptionsMenuClosed(menu);
            _optionsMenuOpen = false;
            UnbindService(this);
            Finish();
        }
    }
}