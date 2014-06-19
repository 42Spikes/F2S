using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cirrious.MvvmCross.ViewModels;
//using PropertyChanged;

namespace F2S.MvvmX.iOS.SplitView.Core.ViewModels
{
  //  [ImplementPropertyChanged]
    public class MvxStaticCardViewModel : MvxViewModel
    {
        public string Text { get; set; }
        public string Footer { get; set; }

        public byte[] Background { get; set; }
        public ObservableCollection<byte[]> Mosaics { get; set; }

        public MvxStaticCardViewModel()
        {
            Text = "Foo";
            Footer = "Bar";
        }

        public MvxStaticCardViewModel(string text, string footer = null, byte[] background = null, IEnumerable<byte[]> mosaics = null)
        {
            Text = text;
            Footer = footer;
            Background = background;

            if (mosaics != null) Mosaics = new ObservableCollection<byte[]>(mosaics);
        }
    }
}