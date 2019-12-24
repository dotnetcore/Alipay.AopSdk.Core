using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// ItemInventory Data Structure.
    /// </summary>
    [Serializable]
    public class ItemInventory : AopObject
    {
        /// <summary>
        /// 商品库存扩展属性
        /// </summary>
        [XmlElement("ext_prop")]
        public string ExtProp { get; set; }

        /// <summary>
        /// 外部商品ID
        /// </summary>
        [XmlElement("external_item_id")]
        public string ExternalItemId { get; set; }

        /// <summary>
        /// 商品库存数量
        /// </summary>
        [XmlElement("inventory")]
        public long Inventory { get; set; }
    }
}
