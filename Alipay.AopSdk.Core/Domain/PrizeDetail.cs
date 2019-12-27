using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// PrizeDetail Data Structure.
    /// </summary>
    [Serializable]
    public class PrizeDetail : AopObject
    {
        /// <summary>
        /// 中奖时间
        /// </summary>
        [XmlElement("gmt_time")]
        public string GmtTime { get; set; }

        /// <summary>
        /// 外部奖品id（如果是券，就是券id）
        /// </summary>
        [XmlElement("out_prize_id")]
        public string OutPrizeId { get; set; }

        /// <summary>
        /// 奖品价值,单位分，如支付宝优惠券等类型奖品，可能为0
        /// </summary>
        [XmlElement("price")]
        public string Price { get; set; }

        /// <summary>
        /// 奖品Id
        /// </summary>
        [XmlElement("prize_id")]
        public string PrizeId { get; set; }
    }
}
