using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Response
{
    /// <summary>
    /// ZolozIdentificationCustomerEnrollcertifyQueryResponse.
    /// </summary>
    public class ZolozIdentificationCustomerEnrollcertifyQueryResponse : AopResponse
    {
        /// <summary>
        /// 业务单据号，用于核对和排查
        /// </summary>
        [XmlElement("biz_id")]
        public string BizId { get; set; }
    }
}
