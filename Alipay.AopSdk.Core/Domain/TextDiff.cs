using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// TextDiff Data Structure.
    /// </summary>
    [Serializable]
    public class TextDiff : AopObject
    {
        /// <summary>
        /// 操作类型
        /// </summary>
        [XmlElement("operation")]
        public string Operation { get; set; }

        /// <summary>
        /// 文本内容
        /// </summary>
        [XmlElement("text")]
        public string Text { get; set; }
    }
}
