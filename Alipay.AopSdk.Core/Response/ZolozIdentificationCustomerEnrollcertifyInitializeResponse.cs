using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Response
{
    /// <summary>
    /// ZolozIdentificationCustomerEnrollcertifyInitializeResponse.
    /// </summary>
    public class ZolozIdentificationCustomerEnrollcertifyInitializeResponse : AopResponse
    {
        /// <summary>
        /// 业务单据号，用于核对和排查
        /// </summary>
        [XmlElement("biz_id")]
        public string BizId { get; set; }

        /// <summary>
        /// 人脸注册id
        /// </summary>
        [XmlElement("zim_id")]
        public string ZimId { get; set; }
    }
}
