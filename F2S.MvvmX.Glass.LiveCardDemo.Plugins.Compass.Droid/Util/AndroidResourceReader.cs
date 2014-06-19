using Android.Content;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace F2S.MvvmX.Glass.LiveCardDemo.Plugins.Compass.Droid
{
    public static class AndroidResourceReader
    {
        public static string read(Context context, int id)
        {
            string content;
            using (var sr = new StreamReader(context.Resources.OpenRawResource(id)))
            {
                content = sr.ReadToEnd();
            }

            return content;
        }
    }
}