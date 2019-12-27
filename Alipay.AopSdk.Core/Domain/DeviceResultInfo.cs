using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// DeviceResultInfo Data Structure.
    /// </summary>
    [Serializable]
    public class DeviceResultInfo : AopObject
    {
        /// <summary>
        /// 设备id
        /// </summary>
        [XmlElement("device_id")]
        public string DeviceId { get; set; }

        /// <summary>
        /// 业务数据类型
        /// </summary>
        [XmlElement("device_label")]
        public string DeviceLabel { get; set; }
    }
}
