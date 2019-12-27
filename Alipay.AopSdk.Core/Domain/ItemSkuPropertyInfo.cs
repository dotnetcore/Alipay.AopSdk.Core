using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// ItemSkuPropertyInfo Data Structure.
    /// </summary>
    [Serializable]
    public class ItemSkuPropertyInfo : AopObject
    {
        /// <summary>
        /// 属性
        /// </summary>
        [XmlElement("property_key")]
        public string PropertyKey { get; set; }

        /// <summary>
        /// 属性值
        /// </summary>
        [XmlElement("property_value")]
        public string PropertyValue { get; set; }
    }
}
