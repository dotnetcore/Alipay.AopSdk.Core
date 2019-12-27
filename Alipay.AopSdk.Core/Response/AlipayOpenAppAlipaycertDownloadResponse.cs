using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Response
{
    /// <summary>
    /// AlipayOpenAppAlipaycertDownloadResponse.
    /// </summary>
    public class AlipayOpenAppAlipaycertDownloadResponse : AopResponse
    {
        /// <summary>
        /// 公钥证书Base64后的字符串
        /// </summary>
        [XmlElement("alipay_cert_content")]
        public string AlipayCertContent { get; set; }
    }
}
