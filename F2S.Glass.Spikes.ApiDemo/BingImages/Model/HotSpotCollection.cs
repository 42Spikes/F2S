using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace F2S.Glass.Spikes.ApiDemo.BingImages.Model
{
    public class HotSpotCollection
    {
        [XmlElement("hotspot")]
        public List<HotSpot> HotSpots { get; set; } 
    }
}
