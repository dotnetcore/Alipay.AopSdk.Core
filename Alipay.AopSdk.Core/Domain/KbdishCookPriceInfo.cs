using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// KbdishCookPriceInfo Data Structure.
    /// </summary>
    [Serializable]
    public class KbdishCookPriceInfo : AopObject
    {
        /// <summary>
        /// 菜单id
        /// </summary>
        [XmlElement("cook_id")]
        public string CookId { get; set; }

        /// <summary>
        /// 菜品id
        /// </summary>
        [XmlElement("dish_id")]
        public string DishId { get; set; }

        /// <summary>
        /// 会员价，目前已废弃
        /// </summary>
        [XmlElement("member_price")]
        public string MemberPrice { get; set; }

        /// <summary>
        /// 售卖价格
        /// </summary>
        [XmlElement("sell_price")]
        public string SellPrice { get; set; }

        /// <summary>
        /// skuid
        /// </summary>
        [XmlElement("sku_id")]
        public string SkuId { get; set; }
    }
}
