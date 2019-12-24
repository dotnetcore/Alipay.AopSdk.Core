using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// AlipayOpenAppAlipaycertDownloadModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenAppAlipaycertDownloadModel : AopObject
    {
        /// <summary>
        /// 支付宝公钥证书序列号
        /// </summary>
        [XmlElement("alipay_cert_sn")]
        public string AlipayCertSn { get; set; }
    }
}
