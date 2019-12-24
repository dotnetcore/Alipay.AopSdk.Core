using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// ItemOrderVO Data Structure.
    /// </summary>
    [Serializable]
    public class ItemOrderVO : AopObject
    {
        /// <summary>
        /// 业务扩展信息，比如外部卡码，格式为json格式
        /// </summary>
        [XmlElement("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 商品单ID
        /// </summary>
        [XmlElement("item_order_no")]
        public string ItemOrderNo { get; set; }

        /// <summary>
        /// 分摊至商品上的商户出资金额
        /// </summary>
        [XmlElement("merchant_fund")]
        public string MerchantFund { get; set; }

        /// <summary>
        /// 分摊至商品上的平台出资金额
        /// </summary>
        [XmlElement("platform_fund")]
        public string PlatformFund { get; set; }

        /// <summary>
        /// 商品单价
        /// </summary>
        [XmlElement("price")]
        public string Price { get; set; }

        /// <summary>
        /// 商品数量
        /// </summary>
        [XmlElement("quantity")]
        public long Quantity { get; set; }

        /// <summary>
        /// 商品skuId
        /// </summary>
        [XmlElement("sku_id")]
        public string SkuId { get; set; }

        /// <summary>
        /// 商品单状态
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
