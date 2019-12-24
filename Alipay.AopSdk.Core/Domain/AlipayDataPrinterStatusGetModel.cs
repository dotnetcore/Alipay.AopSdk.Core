using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// AlipayDataPrinterStatusGetModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayDataPrinterStatusGetModel : AopObject
    {
        /// <summary>
        /// 应用token
        /// </summary>
        [XmlElement("access_token")]
        public string AccessToken { get; set; }

        /// <summary>
        /// 应用id
        /// </summary>
        [XmlElement("client_id")]
        public string ClientId { get; set; }

        /// <summary>
        /// 应用秘钥
        /// </summary>
        [XmlElement("client_secret")]
        public string ClientSecret { get; set; }

        /// <summary>
        /// 设备sn号
        /// </summary>
        [XmlElement("device_sn")]
        public string DeviceSn { get; set; }
    }
}
