using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// AlipaySecurityProdIfaaDevicepubkeyQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipaySecurityProdIfaaDevicepubkeyQueryModel : AopObject
    {
        /// <summary>
        /// 用于协商ECDH的publickey，base6编码
        /// </summary>
        [XmlElement("ecdh_publickey")]
        public string EcdhPublickey { get; set; }

        /// <summary>
        /// 已返回记录的最大ID，初次请求输入0
        /// </summary>
        [XmlElement("max_id")]
        public string MaxId { get; set; }

        /// <summary>
        /// 安全设备的ID。
        /// </summary>
        [XmlElement("security_device_id")]
        public string SecurityDeviceId { get; set; }

        /// <summary>
        /// 安全设备类型，SGX或者加密机
        /// </summary>
        [XmlElement("security_schema")]
        public string SecuritySchema { get; set; }
    }
}
