using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// TBMiniShopBo Data Structure.
    /// </summary>
    [Serializable]
    public class TBMiniShopBo : AopObject
    {
        /// <summary>
        /// 门店地址
        /// </summary>
        [XmlElement("address")]
        public string Address { get; set; }

        /// <summary>
        /// json 字符串
        /// </summary>
        [XmlElement("attribute")]
        public string Attribute { get; set; }

        /// <summary>
        /// 优惠券信息
        /// </summary>
        [XmlArray("coupons")]
        [XmlArrayItem("item_bo")]
        public List<ItemBo> Coupons { get; set; }

        /// <summary>
        /// 商品信息
        /// </summary>
        [XmlArray("items")]
        [XmlArrayItem("item_bo")]
        public List<ItemBo> Items { get; set; }

        /// <summary>
        /// 门店图片url
        /// </summary>
        [XmlElement("logo_url")]
        public string LogoUrl { get; set; }

        /// <summary>
        /// 轻店铺id
        /// </summary>
        [XmlElement("mini_shop_id")]
        public string MiniShopId { get; set; }

        /// <summary>
        /// 主店名
        /// </summary>
        [XmlElement("shop_head_name")]
        public string ShopHeadName { get; set; }

        /// <summary>
        /// 口碑店铺id
        /// </summary>
        [XmlElement("shop_id")]
        public string ShopId { get; set; }

        /// <summary>
        /// 店铺名
        /// </summary>
        [XmlElement("shop_name")]
        public string ShopName { get; set; }
    }
}
