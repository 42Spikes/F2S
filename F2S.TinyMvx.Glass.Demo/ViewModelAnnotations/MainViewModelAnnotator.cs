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
using F2S.TinyMvx.Glass.Demo.ViewModels;
using F2S.TinyMvx.Glass.Platform;

namespace F2S.TinyMvx.Glass.Demo.ViewModelAnnotations
{
    public class MainViewModelAnnotator : MvxGlassScrollingCardAnnotation<MainViewModel, MvxGlassScrollingCardView>
    {
        public MainViewModelAnnotator()
        {
        }
    }
}