using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// NearbyGoods Data Structure.
    /// </summary>
    [Serializable]
    public class NearbyGoods : AopObject
    {
        /// <summary>
        /// 活动再减描述，前端直接展示即可
        /// </summary>
        [XmlElement("discount_desc")]
        public string DiscountDesc { get; set; }

        /// <summary>
        /// 店铺距离当前用户的距离，单位为米
        /// </summary>
        [XmlElement("distance")]
        public string Distance { get; set; }

        /// <summary>
        /// 商品图片链接，用于前端展示商品图片
        /// </summary>
        [XmlElement("image_url")]
        public string ImageUrl { get; set; }

        /// <summary>
        /// 商品图片的id值，可用于拼接图片链接
        /// </summary>
        [XmlElement("item_field_id")]
        public string ItemFieldId { get; set; }

        /// <summary>
        /// 商品id,商品唯一标识符，可用于查询单个商品信息
        /// </summary>
        [XmlElement("item_id")]
        public string ItemId { get; set; }

        /// <summary>
        /// 商品名称，用于表征商品基本特性
        /// </summary>
        [XmlElement("item_name")]
        public string ItemName { get; set; }

        /// <summary>
        /// 商品详情跳转地址
        /// </summary>
        [XmlElement("jump_url")]
        public string JumpUrl { get; set; }

        /// <summary>
        /// 商品原价，直接返回给前端，单位为元
        /// </summary>
        [XmlElement("original_price")]
        public string OriginalPrice { get; set; }

        /// <summary>
        /// 促销标，超值抢购 or 促销，此为图片连接
        /// </summary>
        [XmlElement("sales_icon")]
        public string SalesIcon { get; set; }

        /// <summary>
        /// 商品最终售卖价格，单位为元
        /// </summary>
        [XmlElement("selling_price")]
        public string SellingPrice { get; set; }

        /// <summary>
        /// 店铺图片的id值，可用于拼接图片链接
        /// </summary>
        [XmlElement("shop_field_id")]
        public string ShopFieldId { get; set; }

        /// <summary>
        /// 店铺唯一标识
        /// </summary>
        [XmlElement("shop_id")]
        public string ShopId { get; set; }

        /// <summary>
        /// 店铺logo
        /// </summary>
        [XmlElement("shop_logo")]
        public string ShopLogo { get; set; }

        /// <summary>
        /// 适用门店主店名
        /// </summary>
        [XmlElement("shop_name")]
        public string ShopName { get; set; }

        /// <summary>
        /// 店铺轻店铺id
        /// </summary>
        [XmlElement("tb_mini_shop_id")]
        public string TbMiniShopId { get; set; }
    }
}
