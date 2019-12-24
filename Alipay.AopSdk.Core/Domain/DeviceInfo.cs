using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// DeviceInfo Data Structure.
    /// </summary>
    [Serializable]
    public class DeviceInfo : AopObject
    {
        /// <summary>
        /// 设备ID
        /// </summary>
        [XmlElement("device_id")]
        public string DeviceId { get; set; }

        /// <summary>
        /// 设备类型
        /// </summary>
        [XmlElement("device_type")]
        public string DeviceType { get; set; }

        /// <summary>
        /// 设备sn编号
        /// </summary>
        [XmlElement("dv_sn")]
        public string DvSn { get; set; }

        /// <summary>
        /// 生产厂商
        /// </summary>
        [XmlElement("manufacturer")]
        public string Manufacturer { get; set; }

        /// <summary>
        /// 产品型号
        /// </summary>
        [XmlElement("product_model")]
        public string ProductModel { get; set; }
    }
}
