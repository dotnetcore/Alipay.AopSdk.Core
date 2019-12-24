using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// HelloBikePriceResultItem Data Structure.
    /// </summary>
    [Serializable]
    public class HelloBikePriceResultItem : AopObject
    {
        /// <summary>
        /// 优惠卡类型，枚举值为 mcard,qcard,hycard,ycard,tcard
        /// </summary>
        [XmlElement("card_type")]
        public string CardType { get; set; }

        /// <summary>
        /// 推荐价格，单位为分
        /// </summary>
        [XmlElement("promo_price_cent")]
        public long PromoPriceCent { get; set; }
    }
}
