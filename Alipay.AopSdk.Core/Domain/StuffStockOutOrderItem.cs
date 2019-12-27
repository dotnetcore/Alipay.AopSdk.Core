using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// StuffStockOutOrderItem Data Structure.
    /// </summary>
    [Serializable]
    public class StuffStockOutOrderItem : AopObject
    {
        /// <summary>
        /// 扩展字段
        /// </summary>
        [XmlElement("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 商品名称
        /// </summary>
        [XmlElement("item_name")]
        public string ItemName { get; set; }

        /// <summary>
        /// 发货数量
        /// </summary>
        [XmlElement("item_quantity")]
        public long ItemQuantity { get; set; }

        /// <summary>
        /// sku号
        /// </summary>
        [XmlElement("sku_no")]
        public string SkuNo { get; set; }
    }
}
