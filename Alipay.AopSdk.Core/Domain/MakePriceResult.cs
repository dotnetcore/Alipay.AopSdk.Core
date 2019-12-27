using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// MakePriceResult Data Structure.
    /// </summary>
    [Serializable]
    public class MakePriceResult : AopObject
    {
        /// <summary>
        /// 定价对象原价
        /// </summary>
        [XmlElement("base_price_cent")]
        public string BasePriceCent { get; set; }

        /// <summary>
        /// 定价对象类型
        /// </summary>
        [XmlElement("product_type")]
        public string ProductType { get; set; }

        /// <summary>
        /// 定价对象推荐价格
        /// </summary>
        [XmlElement("promo_price")]
        public string PromoPrice { get; set; }
    }
}
