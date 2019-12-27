using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// SkuInfo Data Structure.
    /// </summary>
    [Serializable]
    public class SkuInfo : AopObject
    {
        /// <summary>
        /// 支付宝会员渠道销售的，以分为单位表示的价格，示例中是125.00元
        /// </summary>
        [XmlElement("price_cent")]
        public long PriceCent { get; set; }

        /// <summary>
        /// 商品的划线价，以分为单位，12500表示125元
        /// </summary>
        [XmlElement("reserve_price")]
        public long ReservePrice { get; set; }

        /// <summary>
        /// 商品的skuId
        /// </summary>
        [XmlElement("sku_id")]
        public string SkuId { get; set; }
    }
}
