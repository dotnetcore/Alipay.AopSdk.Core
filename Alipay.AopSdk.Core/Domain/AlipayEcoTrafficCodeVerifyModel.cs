using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// AlipayEcoTrafficCodeVerifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEcoTrafficCodeVerifyModel : AopObject
    {
        /// <summary>
        /// 凭证服务类型
        /// </summary>
        [XmlElement("cert_service_type")]
        public string CertServiceType { get; set; }

        /// <summary>
        /// 凭证类型（卡类型）
        /// </summary>
        [XmlElement("cert_type")]
        public string CertType { get; set; }

        /// <summary>
        /// 码值/脱机记录
        /// </summary>
        [XmlElement("offline_cert")]
        public string OfflineCert { get; set; }

        /// <summary>
        /// 解析类型：QRCODE/RECORD
        /// </summary>
        [XmlElement("parse_mode")]
        public string ParseMode { get; set; }

        /// <summary>
        /// 支付宝用户id
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
