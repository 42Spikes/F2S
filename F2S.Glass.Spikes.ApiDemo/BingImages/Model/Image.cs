using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace F2S.Glass.Spikes.ApiDemo.BingImages.Model
{
    [XmlRoot("image")]
    [XmlInclude(typeof(HotSpot))]
    public class Image
    {
        [XmlElement("startdate")]
        public string StartDateAsString { get; set; }
        [XmlElement("fullstartdate")]
        public string FullStartDateAsString { get; set; }
        [XmlElement("enddate")]
        public string EndDateAsString { get; set; }
        [XmlElement("url")]
        public string URL { get; set; }
        [XmlElement("urlBase")]
        public string URLBase { get; set; }
        [XmlElement("copyright")]
        public string Copyright { get; set; }
        [XmlElement("copyrightlink")]
        public string CopyrightLink { get; set; }

        [XmlElement("drk")]
        public int Drk { get; set; }
        [XmlElement("top")]
        public int Top { get; set; }
        [XmlElement("bot")]
        public int Bot { get; set; }

        [XmlElement("hotspots")]
        public HotSpotCollection HotSpots { get; set; }

        [XmlIgnore]
        public DateTime? StartDate
        {
            get { return createDateTime(StartDateAsString); }
        }
        [XmlIgnore]
        public DateTime? FullStartDate
        {
            get { return createDateTime(FullStartDateAsString); }
        }
        [XmlIgnore]
        public DateTime? EndDate
        {
            get { return createDateTime(EndDateAsString); }
        }

        private DateTime? createDateTime(string dateAsString)
        {
            if (string.IsNullOrEmpty(dateAsString) || (dateAsString.Length != 8 && dateAsString.Length != 12))
                return null;
            var time = "0000";
            var year = int.Parse(dateAsString.Substring(0, 4));
            var month = int.Parse(dateAsString.Substring(4, 2));
            var day = int.Parse(dateAsString.Substring(6, 2));

            return new DateTime(year, month, day);
        }
    }
}
