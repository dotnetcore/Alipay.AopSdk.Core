using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// GoodsInformation Data Structure.
    /// </summary>
    [Serializable]
    public class GoodsInformation : AopObject
    {
        /// <summary>
        /// 购买的商品个数
        /// </summary>
        [XmlElement("quantity")]
        public long Quantity { get; set; }

        /// <summary>
        /// 基于alipay商品库的skuId
        /// </summary>
        [XmlElement("sku_id")]
        public string SkuId { get; set; }
    }
}
