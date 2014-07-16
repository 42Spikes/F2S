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
using F2S.MvvmX.Samples.Unified.Glass.Components.Compass.Model;
using F2S.MvvmX.Samples.Unified.Glass.Components.Compass.Utils;
using F2S.TinyMvx;
using F2S.MvvmX.Samples.Unified.Glass.Plugins.TextToSpeech;
using F2S.TinyMvx.Glass;

namespace F2S.MvvmX.Samples.Unified.Glass.Components.Compass.Services
{
    [Service]
    public class CompassService : MvxAndroidService, IMvxNavigable
    {
        private OrientationManager _orientationManager;
        public OrientationManager OrientationManager
        {
            get { return _orientationManager; }
        }

        private Landmarks _landmarks;
        public Landmarks Landmarks { get { return _landmarks; } }

        private CompassServiceBinder _binder;

        public CompassService()
        {
            _binder = new CompassServiceBinder(this);
        }

        public void ShowViewModel<T>(object parameters = null)
        {
            var presenter = Mvx.Resolve<IMvxPresenter>();
            presenter.ShowViewModel<T>(parameters);
        }

        public override IBinder OnBind(Intent intent)
        {
            return _binder;
        }

        public override void OnCreate()
        {
            _orientationManager = new OrientationManager(
                this.getSensorManager(),
                this.getLocationManager());

            _landmarks = new Landmarks(this);

            // note that I put this after the code
            base.OnCreate();
        }

        public override StartCommandResult OnStartCommand(Intent intent, StartCommandFlags flags, int startId)
        {
            return StartCommandResult.Sticky;
        }

        public override void OnDestroy()
        {
            _orientationManager = null;
            _landmarks = null;

            base.OnDestroy();
        }


        public void ShowViewModel(object parameters = null)
        {
            throw new NotImplementedException();
        }
    }
}