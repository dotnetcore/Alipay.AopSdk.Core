using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// AlipayPcreditLoanCreditQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayPcreditLoanCreditQueryModel : AopObject
    {
        /// <summary>
        /// 同提交授信接口请求参数中的out_biz_no
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 代表了一次请求，作为业务幂等性控制
        /// </summary>
        [XmlElement("out_request_no")]
        public string OutRequestNo { get; set; }
    }
}
