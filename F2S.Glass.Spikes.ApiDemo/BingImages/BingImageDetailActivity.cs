using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.Glass.App;
using Android.OS;
using Android.Provider;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using F2S.Glass.Framework;

namespace F2S.Glass.Spikes.ApiDemo.BingImages
{
    [Activity]
    public class BingImageDetailActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            var intent = this.Intent;
            var b = intent.Extras;

            var imagePosition = b.GetInt("ImagePosition");
            if (imagePosition != -1)
            {
                var image = BingImagesActivity.BIS.Images[imagePosition];
                var card = new Card(this);
                card.SetText(image.Image.Copyright);
                SetContentView(card.View);
            }
        }
    }
}