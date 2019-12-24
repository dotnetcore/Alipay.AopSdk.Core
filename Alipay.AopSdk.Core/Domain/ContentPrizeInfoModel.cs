using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// ContentPrizeInfoModel Data Structure.
    /// </summary>
    [Serializable]
    public class ContentPrizeInfoModel : AopObject
    {
        /// <summary>
        /// 奖品id
        /// </summary>
        [XmlElement("prize_id")]
        public string PrizeId { get; set; }

        /// <summary>
        /// 奖品logo
        /// </summary>
        [XmlElement("prize_logo")]
        public string PrizeLogo { get; set; }

        /// <summary>
        /// 奖品名称
        /// </summary>
        [XmlElement("prize_name")]
        public string PrizeName { get; set; }
    }
}
