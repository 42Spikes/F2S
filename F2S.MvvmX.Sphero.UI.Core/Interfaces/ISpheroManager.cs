using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using F2S.MvvmX.Plugins.Sphero.Interfaces;

namespace F2S.MvvmX.Sphero.UI.Core.Interfaces
{
    public interface ISpheroManager
    {
        Dictionary<string, ConnectedSphero> ConnectedSpheros { get; set; }

        void Register(ConnectedSphero sphero);
    }
}
