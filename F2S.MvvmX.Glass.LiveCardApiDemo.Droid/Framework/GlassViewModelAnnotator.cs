using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.Glass.Timeline;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Cirrious.MvvmCross.ViewModels;
using F2S.MvvmX.Glass.LiveCardApiDemo.Droid.Util;

namespace F2S.MvvmX.Glass.LiveCardApiDemo.Droid.Framework
{
    public abstract class GlassViewModelAnnotator
    {
        public static Dictionary<Type, Type> Annotators { get; set; }

        static GlassViewModelAnnotator()
        {
            Annotators = new Dictionary<Type, Type>();
        }

        public static void init()
        {
            
        }
    }

    public abstract class DirectRenderingViewModelAnnotator : GlassViewModelAnnotator
    {

        public static void init()
        {
            GlassViewModelAnnotator.init();
        }
    }

    public class DirectRenderingViewModelAnnotator<T, R>
        : DirectRenderingViewModelAnnotator
        where T : MvxViewModel
        where R : GlassDirectRenderingCallbackTarget
    {
        static DirectRenderingViewModelAnnotator()
        {
            Annotators[typeof (T)] = typeof (R);
        }


        public static void init()
        {
            DirectRenderingViewModelAnnotator.init();
        }

    }
}