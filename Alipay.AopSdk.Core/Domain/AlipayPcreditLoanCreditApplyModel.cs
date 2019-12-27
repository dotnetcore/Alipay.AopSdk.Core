using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// AlipayPcreditLoanCreditApplyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayPcreditLoanCreditApplyModel : AopObject
    {
        /// <summary>
        /// 授权授信状态，取值范围{"unAuthorized", "authorized"}, authorized-已授权, unAuthorized-未授权
        /// </summary>
        [XmlElement("authorized_status")]
        public string AuthorizedStatus { get; set; }

        /// <summary>
        /// 授信申请回跳地址，商户端提供的地址
        /// </summary>
        [XmlElement("back_url")]
        public string BackUrl { get; set; }

        /// <summary>
        /// 授信申请业务标准外部订单号，代表商户端自己订单号
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
