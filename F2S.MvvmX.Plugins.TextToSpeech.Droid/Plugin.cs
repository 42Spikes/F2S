using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Cirrious.CrossCore;
using Cirrious.CrossCore.Plugins;

namespace F2S.MvvmX.Plugins.TextToSpeech.Droid
{

    public class Plugin : IMvxPlugin
    {
        public void Load()
        {
            Mvx.RegisterSingleton<ITextToSpeech>(new TextToSpeech());
        }
    }
}
