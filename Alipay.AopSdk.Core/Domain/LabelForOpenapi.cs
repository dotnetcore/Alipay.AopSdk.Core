using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// LabelForOpenapi Data Structure.
    /// </summary>
    [Serializable]
    public class LabelForOpenapi : AopObject
    {
        /// <summary>
        /// 标记类型
        /// </summary>
        [XmlElement("label_type")]
        public string LabelType { get; set; }

        /// <summary>
        /// 标记类型的值
        /// </summary>
        [XmlElement("value")]
        public string Value { get; set; }
    }
}
