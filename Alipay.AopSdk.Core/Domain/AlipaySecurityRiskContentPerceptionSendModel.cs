using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// AlipaySecurityRiskContentPerceptionSendModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipaySecurityRiskContentPerceptionSendModel : AopObject
    {
        /// <summary>
        /// 业务时间。日期格式化后的字符串。
        /// </summary>
        [XmlElement("business_time")]
        public string BusinessTime { get; set; }

        /// <summary>
        /// 创建时间。日期格式化后的字符串，和business_time区分，标识计算引擎得出指标的时间。
        /// </summary>
        [XmlElement("create_time")]
        public string CreateTime { get; set; }

        /// <summary>
        /// 持续时间。单位默认1min。
        /// </summary>
        [XmlElement("duration")]
        public long Duration { get; set; }

        /// <summary>
        /// 风险感知度量的键
        /// </summary>
        [XmlElement("metric")]
        public string Metric { get; set; }

        /// <summary>
        /// 风险感知度量的值。对应为metric的值。通常是一个可解析的json串。
        /// </summary>
        [XmlElement("value")]
        public string Value { get; set; }
    }
}
