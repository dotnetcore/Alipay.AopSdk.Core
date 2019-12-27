using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// AutoMktTouchExtendInfoEntry Data Structure.
    /// </summary>
    [Serializable]
    public class AutoMktTouchExtendInfoEntry : AopObject
    {
        /// <summary>
        /// 扩展信息元素的Key值。
        /// </summary>
        [XmlElement("key")]
        public string Key { get; set; }

        /// <summary>
        /// 扩展字段的值
        /// </summary>
        [XmlElement("value")]
        public string Value { get; set; }
    }
}
