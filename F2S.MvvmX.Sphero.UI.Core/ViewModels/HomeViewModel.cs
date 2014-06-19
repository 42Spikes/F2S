using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Cirrious.CrossCore.UI;
using Cirrious.MvvmCross.ViewModels;
using F2S.MvvmX.Plugins.Sphero.Commands;
using F2S.MvvmX.Plugins.Sphero.Interfaces;
using F2S.MvvmX.Sphero.UI.Core.Interfaces;

namespace F2S.MvvmX.Sphero.UI.Core.ViewModels
{
    public class HomeViewModel : MvxViewModel
    {
        private ISpheroListService _spheroListService;
        private ISpheroManager _spheroManager;

        private ObservableCollection<IAvailableSphero> _availableSpheros; 
        public ObservableCollection<IAvailableSphero> AvailableSpheros
        {
            get { return _availableSpheros; }
            set
            {
                _availableSpheros = value;
                RaisePropertyChanged(() => AvailableSpheros);
            }
        }

        public ICommand SpheroSelectedCommand
        {
            get
            {
                return
                    new MvxCommand<IAvailableSphero>(
                        async availableSphero =>
                        {
                            try
                            {
                                //ShowViewModel<MainSpheroViewModel>(
                                  //  new MainSpheroViewModel.Parameters() {});

                                var connectedSphero = await availableSphero.ConnectAsync();
                                var sphero = new ConnectedSphero(connectedSphero);
                                
                                _spheroManager.Register(sphero);

                                ShowViewModel<MainSpheroViewModel>(
                                    new MainSpheroViewModel.Parameters() { Name = sphero.Name });
                            }
                            catch (Exception e) 
                            {
                            }
                        });
            }
        }

        public HomeViewModel(ISpheroListService spheroListService, ISpheroManager spheroManager)
        {
            _spheroListService = spheroListService;
            _spheroManager = spheroManager;

            _spheroListService.PropertyChanged +=_spheroListService_PropertyChanged;
            _spheroListService.RefreshList();
        }

        void _spheroListService_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
 	        AvailableSpheros = new ObservableCollection<IAvailableSphero>(_spheroListService.AvailableSpheros);
        }


        public void OnItemSelect()
        {

        }
    }
}
