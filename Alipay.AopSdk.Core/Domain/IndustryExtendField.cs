using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// IndustryExtendField Data Structure.
    /// </summary>
    [Serializable]
    public class IndustryExtendField : AopObject
    {
        /// <summary>
        /// 扩展参数的key值
        /// </summary>
        [XmlElement("key")]
        public string Key { get; set; }

        /// <summary>
        /// 扩展参数的value值
        /// </summary>
        [XmlElement("value")]
        public string Value { get; set; }
    }
}
