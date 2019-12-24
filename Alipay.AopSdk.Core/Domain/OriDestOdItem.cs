using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// OriDestOdItem Data Structure.
    /// </summary>
    [Serializable]
    public class OriDestOdItem : AopObject
    {
        /// <summary>
        /// 目的geohash
        /// </summary>
        [XmlElement("dest_geo")]
        public string DestGeo { get; set; }

        /// <summary>
        /// od数量
        /// </summary>
        [XmlElement("od")]
        public long Od { get; set; }

        /// <summary>
        /// 周末
        /// </summary>
        [XmlElement("week_od")]
        public long WeekOd { get; set; }

        /// <summary>
        /// 工作日OD
        /// </summary>
        [XmlElement("work_od")]
        public long WorkOd { get; set; }
    }
}
