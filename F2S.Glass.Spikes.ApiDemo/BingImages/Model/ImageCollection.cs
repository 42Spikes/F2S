using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace F2S.Glass.Spikes.ApiDemo.BingImages.Model
{
    [XmlRoot("images")]
    [XmlInclude(typeof(Image))]
    public class ImageCollection
    {
        [XmlElement("image")]
        public List<Image> Images { get; set; }
    }
}
