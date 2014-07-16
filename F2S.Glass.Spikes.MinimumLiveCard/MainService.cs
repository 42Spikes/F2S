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

namespace F2S.Glass.Spikes.Minimal.RemoteView
{
    [Service(Icon = "@drawable/icon")]
    [IntentFilter(new [] { "com.google.android.glass.action.VOICE_TRIGGER" })]
    [MetaData("com.google.android.glass.VoiceTrigger", Resource = "@xml/voicetriggerstart")]
    public class MainService : Service
    {
        private LiveCard _card;
        private Android.Widget.RemoteViews _remoteViews;

        public override IBinder OnBind(Intent intent)
        {
            return null;
        }

        public override StartCommandResult OnStartCommand(Intent intent, StartCommandFlags flags, int startId)
        {
            if (_card == null)
            {
                _card = new LiveCard(Application, "remoteviewservice");
                _remoteViews = new Android.Widget.RemoteViews(PackageName, Resource.Layout.MainLayout);
                _remoteViews.SetTextViewText(Resource.Id.LivecardContent, "HI From Remote View!");
                _card.SetViews(_remoteViews);

                var menuIntent = new Intent(this, typeof(MenuActivity));
                menuIntent.AddFlags(ActivityFlags.NewTask | ActivityFlags.ClearTask);
                _card.SetAction(PendingIntent.GetActivity(this, 0, menuIntent, 0));
                _card.Publish(LiveCard.PublishMode.Reveal);
            }

            return StartCommandResult.Sticky;

        }

        public override void OnDestroy()
        {
            if (_card != null && _card.IsPublished)
            {
                _card.Unpublish();
                _card = null;
            }

            base.OnDestroy();
        }
    }
}