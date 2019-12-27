using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// AssetDeliveryProcessInfo Data Structure.
    /// </summary>
    [Serializable]
    public class AssetDeliveryProcessInfo : AopObject
    {
        /// <summary>
        /// 调拨指令ID
        /// </summary>
        [XmlElement("assign_item_id")]
        public string AssignItemId { get; set; }

        /// <summary>
        /// 对调拨指令的对应批次反馈
        /// </summary>
        [XmlElement("batch_no")]
        public string BatchNo { get; set; }

        /// <summary>
        /// 数量
        /// </summary>
        [XmlElement("count")]
        public string Count { get; set; }

        /// <summary>
        /// 送货单编号
        /// </summary>
        [XmlElement("delivery_process_no")]
        public string DeliveryProcessNo { get; set; }

        /// <summary>
        /// 物料id
        /// </summary>
        [XmlElement("item_id")]
        public string ItemId { get; set; }
    }
}
