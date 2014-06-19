using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace F2S.MvvmX.Glass.ApiDemo
{
    public class CardViewModelInfo
    {
        public MethodInfo TextMethodInfo { get; private set; }
        public MethodInfo FooterMethodInfo { get; private set; }
        public MethodInfo BackgroundMethodInfo { get; set; }
        public CardViewModelInfo(MethodInfo textMethodInfo, MethodInfo footerMethodInfo, MethodInfo backgroundMethodInfo = null)
        {
            // TODO: Complete member initialization
            TextMethodInfo = textMethodInfo;
            FooterMethodInfo = footerMethodInfo;
            BackgroundMethodInfo = backgroundMethodInfo;
        }

        public string getText(object instance)
        {
            return (string)TextMethodInfo.Invoke(instance, null);
        }

        public string getFooter(object instance)
        {
            return (string)FooterMethodInfo.Invoke(instance, null);
        }

        public byte[] getBackgroundBytes(object instance)
        {
            if (BackgroundMethodInfo == null) return null;
            return (byte[]) BackgroundMethodInfo.Invoke(instance, null);
        }
    }
}
