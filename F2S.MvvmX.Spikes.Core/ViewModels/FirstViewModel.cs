using Cirrious.MvvmCross.ViewModels;

namespace F2S.MvvmX.Spikes.Core.ViewModels
{
    public class FirstViewModel 
		: MvxViewModel
    {
		private string _hello = "Hello MvvmCross";
        public string Hello
		{ 
			get { return _hello; }
			set { _hello = value; RaisePropertyChanged(() => Hello); }
		}

        public FirstViewModel()
        {
            
        }
    }
}
