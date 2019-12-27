using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// GoodsReturnOrderItem Data Structure.
    /// </summary>
    [Serializable]
    public class GoodsReturnOrderItem : AopObject
    {
        /// <summary>
        /// 扩展字段
        /// </summary>
        [XmlElement("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 单价，单位：元，没有设置0
        /// </summary>
        [XmlElement("price")]
        public string Price { get; set; }

        /// <summary>
        /// 数量
        /// </summary>
        [XmlElement("qty")]
        public string Qty { get; set; }

        /// <summary>
        /// sku名称
        /// </summary>
        [XmlElement("sku_name")]
        public string SkuName { get; set; }

        /// <summary>
        /// sku号
        /// </summary>
        [XmlElement("sku_no")]
        public string SkuNo { get; set; }
    }
}
