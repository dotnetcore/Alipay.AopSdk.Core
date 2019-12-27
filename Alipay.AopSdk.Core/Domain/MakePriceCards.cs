using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// MakePriceCards Data Structure.
    /// </summary>
    [Serializable]
    public class MakePriceCards : AopObject
    {
        /// <summary>
        /// 定价对象原价
        /// </summary>
        [XmlElement("base_price_cent")]
        public long BasePriceCent { get; set; }

        /// <summary>
        /// 期望推荐价格，注意：不要频繁变动。
        /// </summary>
        [XmlElement("expect_promo_price")]
        public string ExpectPromoPrice { get; set; }

        /// <summary>
        /// 定价区间下限
        /// </summary>
        [XmlElement("lower_promo_price")]
        public long LowerPromoPrice { get; set; }

        /// <summary>
        /// 定价对象类型
        /// </summary>
        [XmlElement("product_type")]
        public string ProductType { get; set; }

        /// <summary>
        /// 定价区间上限
        /// </summary>
        [XmlElement("upper_promo_price")]
        public long UpperPromoPrice { get; set; }
    }
}
