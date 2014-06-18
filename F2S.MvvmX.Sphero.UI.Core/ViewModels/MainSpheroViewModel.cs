using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Cirrious.MvvmCross.ViewModels;
using F2S.MvvmX.Plugins.Sphero.Commands;
using F2S.MvvmX.Plugins.Sphero.Interfaces;
using F2S.MvvmX.Sphero.UI.Core.Interfaces;

namespace F2S.MvvmX.Sphero.UI.Core.ViewModels
{
    public class MainSpheroViewModel : MvxViewModel
    {
        private ISpheroManager _spheroManager;
        private ConnectedSphero _sphero;

        public class Parameters
        {
            public string Name { get; set; }
        }

        public ICommand RollCommand
        {
            get
            {
                return new MvxCommand(
                    async () =>
                    {
                        await _sphero.roll();
                    });
            }
        }

        public ICommand StreamCommand
        {
            get
            {
                return new MvxCommand(
                    async () =>
                    {
                        _sphero.Sphero.SendAndReceive(
                            new SetDataStreamingCommand(),
                            success =>
                            {

                            },
                            error =>
                            {

                            });
                    });
            }
        }

        public void Init(Parameters parameters)
        {
            try
            {
                //_sphero = _spheroManager.ConnectedSpheros[parameters.Name];
            }
            catch (Exception e)
            {
            }
        }

        public MainSpheroViewModel(ISpheroManager spheroManager)
        {
            _spheroManager = spheroManager;
        }
    }
}
