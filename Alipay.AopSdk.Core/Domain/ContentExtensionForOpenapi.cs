using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// ContentExtensionForOpenapi Data Structure.
    /// </summary>
    [Serializable]
    public class ContentExtensionForOpenapi : AopObject
    {
        /// <summary>
        /// 扩展信息正文,新建内容的扩展信息存入这个字段。
        /// </summary>
        [XmlElement("extension")]
        public string Extension { get; set; }

        /// <summary>
        /// 扩展类型,新建内容的扩展类型。RICH_TEXT，代表富文本。
        /// </summary>
        [XmlElement("extension_type")]
        public string ExtensionType { get; set; }
    }
}
