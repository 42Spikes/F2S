using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Speech.Tts;
using Android.Views;
using Android.Widget;

namespace F2S.Glass.Spikes.ApiDemo.TextToSpeech
{
    public interface ITextToSpeech
    {
        void Speak(string phrase);
    }

    public class TextToSpeech : ITextToSpeech
    {
        public class OnInitListener : Java.Lang.Object, Android.Speech.Tts.TextToSpeech.IOnInitListener
        {
            public Action<OperationResult> InitHandler { get; set; }

            public void OnInit(Android.Speech.Tts.OperationResult status)
            {
                if (InitHandler != null) InitHandler(status);
            }
        }

        private OnInitListener _listener;
        private Android.Speech.Tts.TextToSpeech _tts;
        private bool _initialized;
        public TextToSpeech()
        {
            _listener = new OnInitListener() {InitHandler = initHandler};
            _tts = new Android.Speech.Tts.TextToSpeech(Application.Context, _listener);
        }

        private void initHandler(OperationResult r)
        {
            _initialized = true;
        }

        public void Speak(string phrase)
        {
            if (_initialized)
            {
                _tts.Speak(phrase, QueueMode.Flush, null);
            }
        }
    }
}