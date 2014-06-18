using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

using Android.App;
using Android.Content;
using Android.Glass.App;
using Android.Graphics;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Cirrious.MvvmCross.Binding.BindingContext;
using Cirrious.MvvmCross.ViewModels;

namespace F2S.MvvmX.Glass.ApiDemo.Controls
{
    public class MvxCard : MvxViewModel
    {
        public Action<MvxCard> OnCardUpdated { get; set; }
        public Card Card { get; private set; }
        public MvxViewModel ViewModel { get; private set; }
        public CardViewModelInfo CardInfo { get; private set; }
        public MvxCard(Context ctx, CardViewModelInfo vmi, MvxViewModel viewModel) 
        {
            Card = new Card(ctx);
            ViewModel = viewModel;
            CardInfo = vmi;

            var inpc = viewModel as INotifyPropertyChanged;
            if (inpc != null)
            {
                inpc.PropertyChanged += inpc_PropertyChanged;
            }
            Card.SetText(CardInfo.getText(viewModel));
            Card.SetFootnote(CardInfo.getFooter(viewModel));

            var bkg = CardInfo.getBackgroundBytes(viewModel);
            if (bkg != null)
            {
                var bmp = BitmapFactory.DecodeByteArray(bkg, 0, bkg.Length);
                Card.AddImage(bmp);
                Card.SetImageLayout(Card.ImageLayout.Full);
            }
        }

        void inpc_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            Card.SetText(CardInfo.getText(ViewModel));
            Card.SetFootnote(CardInfo.getFooter(ViewModel));

            if (OnCardUpdated != null) OnCardUpdated(this);
        }
    }
}