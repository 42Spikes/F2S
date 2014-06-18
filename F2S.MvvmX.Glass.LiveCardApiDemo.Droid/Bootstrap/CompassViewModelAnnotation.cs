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
using F2S.MvvmX.Glass.LiveCardApiDemo.Core.ViewModels;
using F2S.MvvmX.Glass.LiveCardApiDemo.Droid.Framework;
using F2S.MvvmX.Glass.LiveCardApiDemo.Droid.Util;
using F2S.MvvmX.Glass.LiveCardApiDemo.Droid.Views.Compass;

namespace F2S.MvvmX.Glass.LiveCardApiDemo.Droid.Bootstrap
{
    public class CompassViewModelAnnotation :
        DirectRenderingViewModelAnnotator<CompassViewModel, CompassRenderer>
    {
        static CompassViewModelAnnotation()
        {
            
        }
        public CompassViewModelAnnotation()
        {
            
        }
    }
}