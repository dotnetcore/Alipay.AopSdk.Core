using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// ShopPosSchedule Data Structure.
    /// </summary>
    [Serializable]
    public class ShopPosSchedule : AopObject
    {
        /// <summary>
        /// 早班结束时间
        /// </summary>
        [XmlElement("end_time")]
        public string EndTime { get; set; }

        /// <summary>
        /// 班次ID
        /// </summary>
        [XmlElement("id")]
        public string Id { get; set; }

        /// <summary>
        /// 班次名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 用于标识班次顺序
        /// </summary>
        [XmlElement("sort")]
        public long Sort { get; set; }

        /// <summary>
        /// 早班开始时间
        /// </summary>
        [XmlElement("start_time")]
        public string StartTime { get; set; }
    }
}
