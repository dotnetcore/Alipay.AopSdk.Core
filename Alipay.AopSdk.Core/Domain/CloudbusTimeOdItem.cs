using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// CloudbusTimeOdItem Data Structure.
    /// </summary>
    [Serializable]
    public class CloudbusTimeOdItem : AopObject
    {
        /// <summary>
        /// 公交od
        /// </summary>
        [XmlElement("bus_od")]
        public long BusOd { get; set; }

        /// <summary>
        /// 潜在od
        /// </summary>
        [XmlElement("od")]
        public long Od { get; set; }

        /// <summary>
        /// 时间，精确到小时
        /// </summary>
        [XmlElement("time")]
        public string Time { get; set; }

        /// <summary>
        /// 工作日od
        /// </summary>
        [XmlElement("week_od")]
        public long WeekOd { get; set; }

        /// <summary>
        /// 工作日od
        /// </summary>
        [XmlElement("work_od")]
        public long WorkOd { get; set; }
    }
}
