using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// InfoSource Data Structure.
    /// </summary>
    [Serializable]
    public class InfoSource : AopObject
    {
        /// <summary>
        /// 儿童信息来源的类型，目前支持name
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }

        /// <summary>
        /// 信息来源的取值，比如type为name时，value对应儿童的姓名
        /// </summary>
        [XmlElement("value")]
        public string Value { get; set; }
    }
}
