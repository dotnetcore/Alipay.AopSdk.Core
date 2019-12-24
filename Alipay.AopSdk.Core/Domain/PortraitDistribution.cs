using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// PortraitDistribution Data Structure.
    /// </summary>
    [Serializable]
    public class PortraitDistribution : AopObject
    {
        /// <summary>
        /// 分布段的key
        /// </summary>
        [XmlElement("key")]
        public string Key { get; set; }

        /// <summary>
        /// 该分布段的数量
        /// </summary>
        [XmlElement("number")]
        public string Number { get; set; }

        /// <summary>
        /// 该分布段的比例
        /// </summary>
        [XmlElement("ratio")]
        public string Ratio { get; set; }
    }
}
