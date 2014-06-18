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
using Cirrious.CrossCore;
using Cirrious.CrossCore.Plugins;
using F2S.MvvmX.Plugins.TextToSpeech;

namespace F2S.MvvmX.Glass.LiveCardApiDemo.Droid.Bootstrap
{
    public class TextToSpeechPluginBootstrap :
        MvxPluginBootstrapAction<F2S.MvvmX.Plugins.TextToSpeech.PluginLoader>
    {
        public TextToSpeechPluginBootstrap()
        {
            var tts = Mvx.Resolve<ITextToSpeech>();
            tts = null;
        }
    }
}