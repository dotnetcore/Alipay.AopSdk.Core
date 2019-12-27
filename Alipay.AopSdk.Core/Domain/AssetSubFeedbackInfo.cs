using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// AssetSubFeedbackInfo Data Structure.
    /// </summary>
    [Serializable]
    public class AssetSubFeedbackInfo : AopObject
    {
        /// <summary>
        /// 返回的信息code
        /// </summary>
        [XmlElement("code")]
        public string Code { get; set; }

        /// <summary>
        /// 返回值的描述
        /// </summary>
        [XmlElement("desc")]
        public string Desc { get; set; }

        /// <summary>
        /// 具体的值，例如SN号
        /// </summary>
        [XmlElement("value")]
        public string Value { get; set; }
    }
}
