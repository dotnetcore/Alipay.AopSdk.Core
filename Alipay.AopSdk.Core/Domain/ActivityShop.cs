using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// ActivityShop Data Structure.
    /// </summary>
    [Serializable]
    public class ActivityShop : AopObject
    {
        /// <summary>
        /// 承诺消费活动门店地址
        /// </summary>
        [XmlElement("shop_address")]
        public string ShopAddress { get; set; }

        /// <summary>
        /// 承诺消费活动门店ID
        /// </summary>
        [XmlElement("shop_id")]
        public string ShopId { get; set; }

        /// <summary>
        /// 承诺消费门店纬度
        /// </summary>
        [XmlElement("shop_latitude")]
        public string ShopLatitude { get; set; }

        /// <summary>
        /// 承诺消费门店经度信息
        /// </summary>
        [XmlElement("shop_longitude")]
        public string ShopLongitude { get; set; }

        /// <summary>
        /// 承诺消费活动门店名称
        /// </summary>
        [XmlElement("shop_name")]
        public string ShopName { get; set; }
    }
}
