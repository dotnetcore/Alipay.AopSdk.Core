using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// KdsDeviceModel Data Structure.
    /// </summary>
    [Serializable]
    public class KdsDeviceModel : AopObject
    {
        /// <summary>
        /// 设备编号
        /// </summary>
        [XmlElement("device_id")]
        public string DeviceId { get; set; }

        /// <summary>
        /// 设备名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 设备sn号
        /// </summary>
        [XmlElement("sn_id")]
        public string SnId { get; set; }
    }
}
