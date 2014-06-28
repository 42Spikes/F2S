using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F2S.Glass.ApiDemo.Bing.Model
{
    public class ImageModel
    {
        public int ID { get; set; }
        public Image Image { get; set; }
        public string URL { get; set; }
        public byte[] Data { get; set; }

        public string Description { get; set; }
    }
}
