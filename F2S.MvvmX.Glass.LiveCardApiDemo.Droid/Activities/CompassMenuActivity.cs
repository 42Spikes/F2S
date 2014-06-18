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
using Java.Lang;
using F2S.MvvmX.Glass.LiveCardApiDemo.Droid;

namespace F2S.MvvmX.Glass.LiveCardApiDemo.Activities
{
    //[Activity(Label = "CompassMenuActivity", MainLauncher = true)]
    [Activity(Label = "CompassMenuActivity", MainLauncher = false)]
    //[IntentFilter(new[] { "com.google.android.glass.action.VOICE_TRIGGER" })]
    //[MetaData("com.google.android.glass.VoiceTrigger", Resource = "@xml/voicetrigger")]
    public class CompassMenuActivity : Activity, IServiceConnection
    {
        private Handler _handler = new Handler();
        private CompassService.CompassBinder _compassService;
        private bool _attachedToWindow;
        private bool _optionsMenuOpen;

        public void OnServiceConnected(ComponentName name, IBinder service)
        {
            if (service is CompassService.CompassBinder)
            {
                _compassService = (CompassService.CompassBinder)service;
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
            BindService(new Intent(this, typeof (CompassService)), this, Bind.AutoCreate);
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
            if (!_optionsMenuOpen && _attachedToWindow && _compassService != null)
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
                    _compassService.readHeadingAloud();
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