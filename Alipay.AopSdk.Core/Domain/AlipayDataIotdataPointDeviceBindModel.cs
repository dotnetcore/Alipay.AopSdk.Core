using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// AlipayDataIotdataPointDeviceBindModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayDataIotdataPointDeviceBindModel : AopObject
    {
        /// <summary>
        /// 业务id
        /// </summary>
        [XmlElement("business_id")]
        public long BusinessId { get; set; }

        /// <summary>
        /// 设备id
        /// </summary>
        [XmlElement("device_id")]
        public string DeviceId { get; set; }

        /// <summary>
        /// 点位id
        /// </summary>
        [XmlElement("point_id")]
        public long PointId { get; set; }

        /// <summary>
        /// 备注信息
        /// </summary>
        [XmlElement("remark")]
        public string Remark { get; set; }
    }
}
