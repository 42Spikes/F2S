using Android.App;
using Android.OS;
using Cirrious.MvvmCross.Droid.Views;

namespace F2S.MvvmX.Spikes.Droid.Views
{
    [Activity(Label = "View for FirstViewModel")]
    public class FirstView : MvxActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            //SetContentView(Resource.Layout.FirstView);
        }

        protected override void OnViewModelSet()
        {
            base.OnViewModelSet();
        }
    }
}