using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// DeviceApplyOrderItemModel Data Structure.
    /// </summary>
    [Serializable]
    public class DeviceApplyOrderItemModel : AopObject
    {
        /// <summary>
        /// 申请数量，和sn数量保持一致
        /// </summary>
        [XmlElement("apply_amount")]
        public long ApplyAmount { get; set; }

        /// <summary>
        /// 设备编号
        /// </summary>
        [XmlElement("item_id")]
        public string ItemId { get; set; }

        /// <summary>
        /// 设备型号
        /// </summary>
        [XmlElement("item_name")]
        public string ItemName { get; set; }

        /// <summary>
        /// 设备型号
        /// </summary>
        [XmlElement("model_number")]
        public string ModelNumber { get; set; }
    }
}
