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
using Android.Speech.Tts;

namespace F2S.MvvmX.Samples.Unified.Glass.Plugins.TextToSpeech
{
    public class TextToSpeech : ITextToSpeech, Android.Speech.Tts.TextToSpeech.IOnInitListener
    {
        private Android.Speech.Tts.TextToSpeech _tts;

        public TextToSpeech()
        {
            _tts = new Android.Speech.Tts.TextToSpeech(Application.Context, this);
        }

        public void Speak(string text)
        {
            _tts.Speak(text, QueueMode.Flush, null);
        }

        public void OnInit(OperationResult status)
        {
        }

        public IntPtr Handle
        {
            get { throw new NotImplementedException(); }
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}