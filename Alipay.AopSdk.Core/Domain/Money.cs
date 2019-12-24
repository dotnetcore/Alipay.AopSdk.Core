using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// Money Data Structure.
    /// </summary>
    [Serializable]
    public class Money : AopObject
    {
        /// <summary>
        /// 3-letter currency code, refer to ISO 4217 Standard currency alphabetic code
        /// </summary>
        [XmlElement("currency")]
        public string Currency { get; set; }

        /// <summary>
        /// amount value
        /// </summary>
        [XmlElement("value")]
        public string Value { get; set; }
    }
}
