using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// TemplateKeyword Data Structure.
    /// </summary>
    [Serializable]
    public class TemplateKeyword : AopObject
    {
        /// <summary>
        /// 模板中占位符的颜色
        /// </summary>
        [XmlElement("color")]
        public string Color { get; set; }

        /// <summary>
        /// 模板中占位符的值
        /// </summary>
        [XmlElement("value")]
        public string Value { get; set; }
    }
}
