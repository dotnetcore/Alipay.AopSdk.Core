using System;
using System.Xml.Serialization;
using Alipay.AopSdk.Core.Domain;

namespace Alipay.AopSdk.Core.Response
{
    /// <summary>
    /// ZolozIdentificationDeviceinfoQueryResponse.
    /// </summary>
    public class ZolozIdentificationDeviceinfoQueryResponse : AopResponse
    {
        /// <summary>
        /// device_info
        /// </summary>
        [XmlElement("device_info")]
        public ZolozDeviceInfo DeviceInfo { get; set; }
    }
}
