using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// AlipayDataPrinterTokenGetModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayDataPrinterTokenGetModel : AopObject
    {
        /// <summary>
        /// 应用id
        /// </summary>
        [XmlElement("client_id")]
        public string ClientId { get; set; }

        /// <summary>
        /// 授与方式
        /// </summary>
        [XmlElement("grant_type")]
        public string GrantType { get; set; }

        /// <summary>
        /// 权限
        /// </summary>
        [XmlElement("scope")]
        public string Scope { get; set; }

        /// <summary>
        /// 应用秘钥
        /// </summary>
        [XmlElement("secret")]
        public string Secret { get; set; }
    }
}
