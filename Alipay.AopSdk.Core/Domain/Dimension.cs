using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// Dimension Data Structure.
    /// </summary>
    [Serializable]
    public class Dimension : AopObject
    {
        /// <summary>
        /// 维度类型
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 维度值
        /// </summary>
        [XmlElement("value")]
        public string Value { get; set; }
    }
}
