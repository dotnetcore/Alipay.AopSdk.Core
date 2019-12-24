using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// PriceInformation Data Structure.
    /// </summary>
    [Serializable]
    public class PriceInformation : AopObject
    {
        /// <summary>
        /// 对应资产的金额，比如88.66等。如果是现金，单位元
        /// </summary>
        [XmlElement("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// 现金MONEY、家庭分FAMILY_POINT、会员分ANT_POINT等
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }
    }
}
