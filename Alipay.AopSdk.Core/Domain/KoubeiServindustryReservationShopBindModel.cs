using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// KoubeiServindustryReservationShopBindModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiServindustryReservationShopBindModel : AopObject
    {
        /// <summary>
        /// 口碑为第三方ISV分配的渠道标识，如K米的渠道为ISV_KMI
        /// </summary>
        [XmlElement("channel")]
        public string Channel { get; set; }

        /// <summary>
        /// 行业，如KTV，MASSAGE(足疗)等
        /// </summary>
        [XmlElement("industry")]
        public string Industry { get; set; }

        /// <summary>
        /// 商户在ISV创建的门店id
        /// </summary>
        [XmlElement("out_shop_id")]
        public string OutShopId { get; set; }

        /// <summary>
        /// 商户在口碑创建的门店id
        /// </summary>
        [XmlElement("shop_id")]
        public string ShopId { get; set; }
    }
}
