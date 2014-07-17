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
using F2S.Glass.Spikes.ApiDemo.BingImages.Model;

namespace F2S.Glass.Spikes.ApiDemo.BingImages
{
    public interface IBingImageService
    {
        void FavoriteImage(string imageURL);
        ImageModel GetImageModel(string url);
        void Load(int start, int count);
    }
}