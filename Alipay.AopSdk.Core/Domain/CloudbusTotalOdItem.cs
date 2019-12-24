using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// CloudbusTotalOdItem Data Structure.
    /// </summary>
    [Serializable]
    public class CloudbusTotalOdItem : AopObject
    {
        /// <summary>
        /// 返回码
        /// </summary>
        [XmlElement("code")]
        public string Code { get; set; }

        /// <summary>
        /// 消息提示
        /// </summary>
        [XmlElement("message")]
        public string Message { get; set; }

        /// <summary>
        /// 客流总量值(日均)
        /// </summary>
        [XmlElement("totalod")]
        public long Totalod { get; set; }

        /// <summary>
        /// 周末客流总量(日均)
        /// </summary>
        [XmlElement("weekend_od")]
        public long WeekendOd { get; set; }

        /// <summary>
        /// 工作日客流总量(日均)
        /// </summary>
        [XmlElement("workday_od")]
        public long WorkdayOd { get; set; }
    }
}
