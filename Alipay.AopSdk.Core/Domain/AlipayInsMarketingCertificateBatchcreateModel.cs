using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// AlipayInsMarketingCertificateBatchcreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayInsMarketingCertificateBatchcreateModel : AopObject
    {
        /// <summary>
        /// 批量创建凭证请求
        /// </summary>
        [XmlArray("ins_create_certificate_requests")]
        [XmlArrayItem("ins_create_certificate_request")]
        public List<InsCreateCertificateRequest> InsCreateCertificateRequests { get; set; }
    }
}
