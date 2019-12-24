using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// ItemPropertyInfo Data Structure.
    /// </summary>
    [Serializable]
    public class ItemPropertyInfo : AopObject
    {
        /// <summary>
        /// 属性名称
        /// </summary>
        [XmlElement("property_key")]
        public string PropertyKey { get; set; }

        /// <summary>
        /// 属性值列表
        /// </summary>
        [XmlArray("property_value_list")]
        [XmlArrayItem("string")]
        public List<string> PropertyValueList { get; set; }
    }
}
