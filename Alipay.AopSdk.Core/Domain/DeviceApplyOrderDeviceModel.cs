using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// DeviceApplyOrderDeviceModel Data Structure.
    /// </summary>
    [Serializable]
    public class DeviceApplyOrderDeviceModel : AopObject
    {
        /// <summary>
        /// 设备sn编号
        /// </summary>
        [XmlElement("device_sn")]
        public string DeviceSn { get; set; }

        /// <summary>
        /// itemId
        /// </summary>
        [XmlElement("item_id")]
        public string ItemId { get; set; }

        /// <summary>
        /// 厂商id
        /// </summary>
        [XmlElement("supplier_id")]
        public string SupplierId { get; set; }
    }
}
