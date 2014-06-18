using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;

using Android.App;
using Android.Content;
using Android.Content.Res;
using Android.Glass.App;
using Android.Graphics;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Cirrious.CrossCore;
using Cirrious.CrossCore.Exceptions;
//using Cirrious.MvvmCross.Droid.Fragging.Fragments;
using Cirrious.MvvmCross.Droid.Views;
using Cirrious.MvvmCross.ViewModels;
using Cirrious.MvvmCross.Views;
using F2S.MvvmX.Glass.ApiDemo.Controls;
using F2S.MvvmX.Glass.ApiDemo.Views;
using F2S.MvvmX.iOS.SplitView.Core.ViewModels;
using Java.IO;
using Java.Nio;

namespace F2S.MvvmX.Glass.ApiDemo.Presenters
{
    public interface IMvxCardPresenter
    {
        MvxCardActivityHost Host { get; set; }
    }

    public class MvxCardPresenter : MvxAndroidViewPresenter, IMvxCardPresenter
    {
        private MvxCardActivityHost _host;
        public MvxCardActivityHost Host
        {
            get { return _host; }
            set { _host = value; }
        }

        public MvxCardPresenter()
        {
            
        }

        public override void ChangePresentation(Cirrious.MvvmCross.ViewModels.MvxPresentationHint hint)
        {
            base.ChangePresentation(hint);
        }

        public override void Show(Cirrious.MvvmCross.ViewModels.MvxViewModelRequest request)
        {
            var cardInfo = getCardViewModelInfo(request.ViewModelType);
            
            if (_host != null && cardInfo != null)
            {
                show(request, cardInfo);

                return;
            }
            else base.Show(request);
        }

        private MvxCard _card;
        private CardViewModelInfo _cardInfo;

        private void show(MvxViewModelRequest request, CardViewModelInfo cardInfo)
        {
            _cardInfo = cardInfo;

            var viewModelLoader = Mvx.Resolve<IMvxViewModelLoader>();
            var vm = viewModelLoader.LoadViewModel(request, null);

            if (vm is MvxStaticCardViewModel)
            {
                //var bmp = BitmapFactory.DecodeResource(null, Resource.Drawable.braque899);
                //var bytes = bmp.ByteCount;
                //var buffer = ByteBuffer.Allocate(bytes);
                //bmp.CopyPixelsToBuffer(buffer);
                //((MainViewModel) vm).Background = buffer.ToArray<byte>();
            }

            _card = new MvxCard(_host.ApplicationContext, _cardInfo, (MvxViewModel)vm);
            _card.OnCardUpdated = card => _host.SetContentView(card.Card.View);
            if (_host.CardAttached != null) _host.CardAttached(_card);
            _host.SetContentView(_card.Card.View);
        }

        private CardViewModelInfo getCardViewModelInfo(Type viewModelType)
        {
            var textAccessor = getPropertyAccessor<string>(viewModelType, "Text");
            var footerAccessor = getPropertyAccessor<string>(viewModelType, "Footer");
            if (textAccessor != null && footerAccessor != null)
            {
                var cvmi = new CardViewModelInfo(textAccessor, footerAccessor);
                cvmi.BackgroundMethodInfo = getPropertyAccessor<byte[]>(viewModelType, "Background");
                return cvmi;
            }
            
            return null;
        }

        private MethodInfo getPropertyAccessor<T>(Type t, string propertyName)
        {
            var properties = t.GetProperties();
            var pr = properties.FirstOrDefault(p => p.Name == propertyName);
            return pr != null ? pr.GetGetMethod() : null;
        }

    }
}