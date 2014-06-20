using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.Glass.Timeline;
using Android.Hardware;
using Android.OS;
using Android.Runtime;
using Android.Speech.Tts;
using Android.Views;
using Android.Widget;
using F2S.MvvmX.Glass.Compass.Droid.Model;
using F2S.MvvmX.Glass.Compass.Droid.Util;

namespace F2S.MvvmX.Glass.Compass.Droid
{
    public class CompassService : Service, TextToSpeech.IOnInitListener
    {
        public class CompassBinder : Binder
        {
            private CompassService _service;
            public CompassBinder(CompassService service)
            {
                _service = service;
            }

            public void readHeadingAloud()
            {
                var heading = _service._orientationManager.Heading;
                var res = _service.Resources;
                var spokenDirections = res.GetStringArray(Resource.Array.spoken_directions);
                var directionName = spokenDirections[MathUtils.getHalfWindIndex(heading)];

                var roundedHeading = Math.Round(heading);
                int headingFormat;
                if (roundedHeading == 1)
                {
                    headingFormat = Resource.String.spoken_heading_format_one;
                }
                else
                {
                    headingFormat = Resource.String.spoken_heading_format;
                }

                var headingText = res.GetString(headingFormat, roundedHeading, directionName);
                _service._speech.Speak(headingText, QueueMode.Flush, null);
            }
        }

        private const string LIVE_CARD_TAG = "Compass";

        private CompassBinder _binder;
        private OrientationManager _orientationManager;
        private Landmarks _landmarks;
        private TextToSpeech _speech;

        private LiveCard _liveCard;
        private CompassRenderer _renderer;

        public CompassService()
        {
            _binder = new CompassBinder(this);
        }

        public override void OnCreate()
        {
            base.OnCreate();

            _speech = new TextToSpeech(this, this);

            _orientationManager = new OrientationManager(
                this.getSensorManager(),
                this.getLocationManager());

            _landmarks = new Landmarks(this);
        }

        public override IBinder OnBind(Intent intent)
        {
            return _binder;
        }

        public override bool OnUnbind(Intent intent)
        {
            return base.OnUnbind(intent);
        }

        public override StartCommandResult OnStartCommand(Intent intent, StartCommandFlags flags, int startId)
        {
            return StartCommandResult.Sticky;
        }

        public override void OnDestroy()
        {
            _speech.Shutdown();
            _speech = null;
            _orientationManager = null;
            _landmarks = null;

            base.OnDestroy();
        }

        public void OnInit(OperationResult status)
        {
            
        }
    }
}