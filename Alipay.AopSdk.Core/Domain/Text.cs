using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// Text Data Structure.
    /// </summary>
    [Serializable]
    public class Text : AopObject
    {
        /// <summary>
        /// 文本消息的内容
        /// </summary>
        [XmlElement("content")]
        public string Content { get; set; }

        /// <summary>
        /// 文本消息的标题
        /// </summary>
        [XmlElement("title")]
        public string Title { get; set; }
    }
}
