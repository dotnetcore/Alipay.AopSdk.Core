using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// CloudBusOdItem Data Structure.
    /// </summary>
    [Serializable]
    public class CloudBusOdItem : AopObject
    {
        /// <summary>
        /// 实际公交od值
        /// </summary>
        [XmlElement("bus_od")]
        public long BusOd { get; set; }

        /// <summary>
        /// geo hash
        /// </summary>
        [XmlElement("dest_geohash")]
        public string DestGeohash { get; set; }

        /// <summary>
        /// 潜在od值
        /// </summary>
        [XmlElement("od")]
        public long Od { get; set; }

        /// <summary>
        /// 非工作日od日均
        /// </summary>
        [XmlElement("week_od")]
        public long WeekOd { get; set; }

        /// <summary>
        /// 工作日od日均
        /// </summary>
        [XmlElement("work_od")]
        public long WorkOd { get; set; }
    }
}
