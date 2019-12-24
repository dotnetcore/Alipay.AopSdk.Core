using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// HelloBikePriceConstraint Data Structure.
    /// </summary>
    [Serializable]
    public class HelloBikePriceConstraint : AopObject
    {
        /// <summary>
        /// 优惠卡原价，单位为分
        /// </summary>
        [XmlElement("base_price_cent")]
        public long BasePriceCent { get; set; }

        /// <summary>
        /// 优惠卡类型，枚举值为 mcard,qcard,hycard,ycard,tcard
        /// </summary>
        [XmlElement("card_type")]
        public string CardType { get; set; }

        /// <summary>
        /// 默认优惠卡打折后的价格，单位为分
        /// </summary>
        [XmlElement("default_promo_price_cent")]
        public long DefaultPromoPriceCent { get; set; }

        /// <summary>
        /// 优惠卡价格区间上限，单位为分
        /// </summary>
        [XmlElement("high_price_cent")]
        public long HighPriceCent { get; set; }

        /// <summary>
        /// 优惠卡价格区间下限，单位为分
        /// </summary>
        [XmlElement("lower_price_cent")]
        public long LowerPriceCent { get; set; }

        /// <summary>
        /// 是否定价
        /// </summary>
        [XmlElement("pricing")]
        public bool Pricing { get; set; }

        /// <summary>
        /// 用户是否可购买
        /// </summary>
        [XmlElement("visible")]
        public bool Visible { get; set; }
    }
}
