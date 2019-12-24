using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// IndexBigbuyItem Data Structure.
    /// </summary>
    [Serializable]
    public class IndexBigbuyItem : AopObject
    {
        /// <summary>
        /// 距离
        /// </summary>
        [XmlElement("distance")]
        public long Distance { get; set; }

        /// <summary>
        /// 图片地址，用于展示商品图片
        /// </summary>
        [XmlElement("image_url")]
        public string ImageUrl { get; set; }

        /// <summary>
        /// 商品详情页跳转链接
        /// </summary>
        [XmlElement("item_detail_url")]
        public string ItemDetailUrl { get; set; }

        /// <summary>
        /// 商品图片的id值，可用于拼接图片链接
        /// </summary>
        [XmlElement("item_field_id")]
        public string ItemFieldId { get; set; }

        /// <summary>
        /// 商品id，唯一标识
        /// </summary>
        [XmlElement("item_id")]
        public string ItemId { get; set; }

        /// <summary>
        /// 商品名称
        /// </summary>
        [XmlElement("item_name")]
        public string ItemName { get; set; }

        /// <summary>
        /// 必抢标文案
        /// </summary>
        [XmlElement("item_tag")]
        public string ItemTag { get; set; }

        /// <summary>
        /// 一般为店名，但当商品为银行卡类型时为商品名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 原价
        /// </summary>
        [XmlElement("original_price")]
        public string OriginalPrice { get; set; }

        /// <summary>
        /// 价格单位
        /// </summary>
        [XmlElement("price_unit")]
        public string PriceUnit { get; set; }

        /// <summary>
        /// 售卖价格
        /// </summary>
        [XmlElement("selling_price")]
        public string SellingPrice { get; set; }

        /// <summary>
        /// 店铺图片的id值，可用于拼接店铺图片链接
        /// </summary>
        [XmlElement("shop_field_id")]
        public string ShopFieldId { get; set; }

        /// <summary>
        /// 店铺id
        /// </summary>
        [XmlElement("shop_id")]
        public string ShopId { get; set; }

        /// <summary>
        /// 店铺logo
        /// </summary>
        [XmlElement("shop_logo")]
        public string ShopLogo { get; set; }

        /// <summary>
        /// 淘宝轻店铺id
        /// </summary>
        [XmlElement("tb_mini_shop_id")]
        public string TbMiniShopId { get; set; }
    }
}
