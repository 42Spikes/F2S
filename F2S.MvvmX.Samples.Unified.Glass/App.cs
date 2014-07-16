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
using F2S.MvvmX.Samples.Unified.Glass.Components.Compass;
using F2S.MvvmX.Samples.Unified.Glass.Components.Compass.Services;
using F2S.TinyMvx;
using F2S.MvvmX.Samples.Unified.Glass.Services;
using F2S.MvvmX.Samples.Unified.Glass.Plugins.TextToSpeech;
using F2S.MvvmX.Samples.Unified.Glass.Components.Compass.ViewModels;
using F2S.MvvmX.Samples.Unified.Glass.Components;
using F2S.MvvmX.Samples.Unified.Glass.ViewModels;
using F2S.TinyMvx.Glass;

namespace F2S.MvvmX.Samples.Unified.Glass
{
    public class App : 
        MvxGlassApplication<
            UnifiedPresenter,
            UnifiedCompositeService>
    {
        public App()
        {
        }

        public override void Initialize()
        {
            base.Initialize();
        }

        public override void InitializationComplete()
        {
            base.InitializationComplete();

            //initializeTextToSpeech();
            //initializeOrientation();
        }

        protected virtual void initializeTextToSpeech()
        {
            var textToSpeech = new Plugins.TextToSpeech.TextToSpeech();
            Mvx.Register(textToSpeech);

        }

        protected virtual void initializeOrientation()
        {
            var orientation = new Plugins.Orientation.Orientation();
            Mvx.Register(orientation);
        }

        protected override void doInitialNavigation()
        {
            base.doInitialNavigation();

            var presenter = Mvx.Resolve<IMvxPresenter>();
            presenter.ShowViewModel<CompassViewModel>(this);
            /*
            var parms = new Dictionary<string, string>()
            {
                {"Text", "Hi"},
                {"Footer", "There"}
            };
            presenter.ShowViewModel<MainViewModel>(this, parms);
             * */
        }
    }

    public class CompassRendererAnnotation : MvxDirectRenderingViewModelAnnotator
        <CompassViewModel, CompassService, CompassRenderer>
    {
        public CompassRendererAnnotation()
        {
        }
    }
    /*
    public class MainViewModelAnnotation : MvxGlassStaticCardAnnotation<MainViewModel>
    {
    }
     * */
}