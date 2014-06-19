using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.Glass.App;
using Android.Glass.Timeline;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Cirrious.CrossCore;
using Cirrious.MvvmCross.Droid.Views;
using Cirrious.MvvmCross.Plugins.Messenger;
using Cirrious.MvvmCross.ViewModels;
using F2S.MvvmX.Glass.LiveCardApiDemo.Activities;
using F2S.MvvmX.Glass.LiveCardApiDemo.Droid.Framework;
using F2S.MvvmX.Glass.LiveCardApiDemo.Droid.Messages;
using F2S.MvvmX.Glass.LiveCardApiDemo.Droid.Views.Compass;
using Java.Lang;
using Exception = System.Exception;

namespace F2S.MvvmX.Glass.LiveCardApiDemo.Droid
{
    public interface ILiveCardPresenter
    {
        //MvxCardActivityHost Host { get; set; }
    }

    public class LiveCardPresenter : MvxAndroidViewPresenter, ILiveCardPresenter
    {
        private LiveCard _liveCard;
        private IMvxMessenger _messenger;

        public LiveCardPresenter()
        {
            _messenger = Mvx.Resolve<IMvxMessenger>();
            _messenger.Subscribe<ServiceStartedMessage>(onServiceStart);
            _messenger.Subscribe<ServiceDestroyedMessage>(onServiceDestroyed);
            _messenger.Subscribe<GlassShowViewModelMessage>(onShowViewModel);
        }

        public override void ChangePresentation(MvxPresentationHint hint)
        {
            base.ChangePresentation(hint);
        }

        private void onShowViewModel(GlassShowViewModelMessage request)
        {
            var shouldPublish = ensureLiveCard(request);

            if (GlassViewModelAnnotator.Annotators.ContainsKey(request.ViewModelType) && shouldPublish)
            {
                var rendererType = GlassViewModelAnnotator.Annotators[request.ViewModelType];
                if (rendererType.IsSubclassOf(typeof(GlassDirectRenderingCallbackTarget)))
                {
                    var renderer =
                        Activator.CreateInstance(rendererType, new[] {request.SenderAsService}) as
                            GlassDirectRenderingCallbackTarget;

                    renderer.attachedService(request.SenderAsService);
                    request.SenderAsService.attachedRenderer(renderer);

                    try
                    {
                        _liveCard
                            .SetDirectRenderingEnabled(true)
                            .SurfaceHolder
                            .AddCallback(renderer.RenderingCallbackWrapper);
                        _liveCard.Attach(request.SenderAsService);

                        var menuIntent = new Intent(request.SenderAsService, typeof(CompassMenuActivity));
                        menuIntent.AddFlags(ActivityFlags.NewTask | ActivityFlags.ClearTask);
                        _liveCard.SetAction(PendingIntent.GetActivity(request.SenderAsService, 0, menuIntent, 0));
                    }
                    catch (Exception ex)
                    {
                    }
                }
                else
                {
                    //var rv = new RemoteViews(request.SenderAsService.PackageName, Resource.Layout.ViewMapNotFound);
                    //rv.SetTextViewText(Resource.Id.LivecardContent, "Unsupported view type: " + request.ViewModelType.Name);
                    //_liveCard.SetViews(rv);
                }
                 
                //var rv = new RemoteViews(request.SenderAsService.PackageName, Resource.Layout.ViewMapNotFound);
                //rv.SetTextViewText(Resource.Id.LivecardContent, "Up and running " + request.ViewModelType.Name);
                //_liveCard.SetViews(rv);

            }
            else
            if (shouldPublish)
            {
                var rv = new RemoteViews(request.SenderAsService.PackageName, Resource.Layout.ViewMapNotFound);
                rv.SetTextViewText(Resource.Id.LivecardContent, "Could not locate annotation for view model: " + request.ViewModelType.Name);
                _liveCard.SetViews(rv);

                var menuIntent = new Intent(request.SenderAsService, typeof(CompassMenuActivity));
                menuIntent.AddFlags(ActivityFlags.NewTask | ActivityFlags.ClearTask);
                _liveCard.SetAction(PendingIntent.GetActivity(request.SenderAsService, 0, menuIntent, 0));
                _liveCard.Attach(request.SenderAsService);
            }


            if (shouldPublish) _liveCard.Publish(LiveCard.PublishMode.Reveal);
            _liveCard.Navigate();
        }

        private bool ensureLiveCard(GlassShowViewModelMessage request)
        {
            if (_liveCard == null)
            {
                _liveCard = new LiveCard(request.SenderAsService, request.SenderAsService.GetType().Name);
                _liveCard.Attach(request.SenderAsService);
                return true;
            }
            return false;
        }

        private void onServiceStart(ServiceStartedMessage message)
        {
        }

        private void onServiceDestroyed(ServiceDestroyedMessage message)
        {
            if (_liveCard != null && _liveCard.IsPublished)
            {
                _liveCard.Unpublish();
            }
        }

        public override void Show(MvxViewModelRequest request)
        {
            _messenger.Publish(new GlassShowViewModelMessage(GlassMvxApp.MainService, request.ViewModelType));
        }
    }
}