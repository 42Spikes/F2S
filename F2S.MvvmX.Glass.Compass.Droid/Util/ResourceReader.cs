using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace F2S.MvvmX.Glass.Compass.Droid.Util
{
    public static class ResourceReader
    {
        private static string read(Context context, int id)
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