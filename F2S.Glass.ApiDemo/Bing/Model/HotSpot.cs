using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace F2S.Glass.ApiDemo.Bing.Model
{
    [XmlRoot("hotspot")]
    public class HotSpot
    {
        [XmlElement("desc")]
        public string Description { get; set; }
        [XmlElement("link")]
        public string Link { get; set; }
        [XmlElement("query")]
        public string Query { get; set; }
        [XmlElement("LocX")]
        public int LocationX { get; set; }
        [XmlElement("LocY")]
        public int LocationY { get; set; }
    }
}
