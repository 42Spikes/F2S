using System;

using Android.App;
using Android.Content;
using Android.Glass.App;
using Android.Glass.Media;
using Android.Media;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace QrCode.Glass
{
    [Activity(Label = "QrCode.Glass", MainLauncher = true, Icon = "@drawable/icon", Enabled = true)]
    [IntentFilter(new String[] { "com.google.android.glass.action.VOICE_TRIGGER" })]
    [MetaData("com.google.android.glass.VoiceTrigger", Resource = "@xml/voicetriggerstart")]
    public class MainActivity : Activity
    {
        int count = 1;

        protected async override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            try
            {
                Window.AddFlags(WindowManagerFlags.KeepScreenOn);

                var scanner = new ZXing.Mobile.MobileBarcodeScanner(this);
                scanner.UseCustomOverlay = true;
                scanner.CustomOverlay = LayoutInflater.Inflate(Resource.Layout.QRScan, null); ;
                var result = await scanner.Scan();

                var audio = (AudioManager)GetSystemService(Context.AudioService);
                audio.PlaySoundEffect((SoundEffect)Sounds.Success);

                Window.ClearFlags(WindowManagerFlags.KeepScreenOn);

                if (result != null)
                {
                    try
                    {
                        var card2 = new Card(this);
                        card2.SetText(result.Text);
                        card2.SetFootnote("Just scanned!");
                        SetContentView(card2.View);
                    }
                    catch (Exception ex)
                    {
                    }
                }
            }
            catch (Exception ex)
            {
            }
		}
	}
}

