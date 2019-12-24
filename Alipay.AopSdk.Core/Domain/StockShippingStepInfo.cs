using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// StockShippingStepInfo Data Structure.
    /// </summary>
    [Serializable]
    public class StockShippingStepInfo : AopObject
    {
        /// <summary>
        /// 处理地点
        /// </summary>
        [XmlElement("event_address")]
        public string EventAddress { get; set; }

        /// <summary>
        /// 处理时间
        /// </summary>
        [XmlElement("event_time")]
        public string EventTime { get; set; }

        /// <summary>
        /// 扩展
        /// </summary>
        [XmlElement("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 处理状态
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
