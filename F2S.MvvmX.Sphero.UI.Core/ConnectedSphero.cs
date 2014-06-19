using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cirrious.CrossCore.UI;
using F2S.MvvmX.Plugins.Sphero.Commands;
using F2S.MvvmX.Plugins.Sphero.Interfaces;

namespace F2S.MvvmX.Sphero.UI.Core
{
    public class ConnectedSphero
    {
        private IConnectedSphero _sphero;
        public IConnectedSphero Sphero { get { return _sphero; }}

        public string Name { get { return _sphero.Name; }}

        public ConnectedSphero(IConnectedSphero sphero)
        {
            _sphero = sphero;
        }

        public async Task<ISpheroMessage> setColorLED(double red, double green, double blue)
        {
            return await _sphero.SendAndReceiveAsync(new SetColorLedCommand(
                new MvxColor((int)(255 * red), (int)(255*green), (int)(255*blue))));
        }

        public async Task<ISpheroMessage> setBackLED(double brightness)
        {
            return await _sphero.SendAndReceiveAsync(new BackLedCommand((int)(255 * brightness)));
        }

        public async Task<ISpheroMessage> roll()
        {
            return await _sphero.SendAndReceiveAsync(new RollCommand(64, 0, false));
        }
    }
}
