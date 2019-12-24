using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// ActionProperty Data Structure.
    /// </summary>
    [Serializable]
    public class ActionProperty : AopObject
    {
        /// <summary>
        /// 属性C端渲染key
        /// </summary>
        [XmlElement("key")]
        public string Key { get; set; }

        /// <summary>
        /// 交互动作属性元素类型，IMG-图片；TEXT-普通文本
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }

        /// <summary>
        /// 属性图片URL；属性文本值
        /// </summary>
        [XmlElement("value")]
        public string Value { get; set; }
    }
}
