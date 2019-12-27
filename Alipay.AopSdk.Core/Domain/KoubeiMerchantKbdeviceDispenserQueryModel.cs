using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// KoubeiMerchantKbdeviceDispenserQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiMerchantKbdeviceDispenserQueryModel : AopObject
    {
        /// <summary>
        /// 取餐柜的唯一设备ID
        /// </summary>
        [XmlElement("device_id")]
        public string DeviceId { get; set; }
    }
}
