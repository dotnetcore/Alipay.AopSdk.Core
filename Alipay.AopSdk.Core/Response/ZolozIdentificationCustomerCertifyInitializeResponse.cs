using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Response
{
    /// <summary>
    /// ZolozIdentificationCustomerCertifyInitializeResponse.
    /// </summary>
    public class ZolozIdentificationCustomerCertifyInitializeResponse : AopResponse
    {
        /// <summary>
        /// 业务单据号，用于核对和排查
        /// </summary>
        [XmlElement("biz_id")]
        public string BizId { get; set; }

        /// <summary>
        /// 实人认证id
        /// </summary>
        [XmlElement("zim_id")]
        public string ZimId { get; set; }
    }
}
