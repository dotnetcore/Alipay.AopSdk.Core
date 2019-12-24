using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// MakePriceAgrs Data Structure.
    /// </summary>
    [Serializable]
    public class MakePriceAgrs : AopObject
    {
        /// <summary>
        /// 属性名称
        /// </summary>
        [XmlElement("key")]
        public string Key { get; set; }

        /// <summary>
        /// 属性值
        /// </summary>
        [XmlElement("value")]
        public string Value { get; set; }
    }
}
