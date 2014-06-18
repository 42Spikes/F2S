using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using F2S.MvvmX.Plugins.Sphero.Interfaces;
using F2S.MvvmX.Sphero.UI.Core.Interfaces;

namespace F2S.MvvmX.Sphero.UI.Core
{
    public class SpheroManager : ISpheroManager
    {
        public Dictionary<string, ConnectedSphero> ConnectedSpheros { get; set; }

        public SpheroManager()
        {
            ConnectedSpheros = new Dictionary<string, ConnectedSphero>();
        }

        public void Register(ConnectedSphero sphero)
        {
            ConnectedSpheros[sphero.Name] = sphero;
        }
    }
}
