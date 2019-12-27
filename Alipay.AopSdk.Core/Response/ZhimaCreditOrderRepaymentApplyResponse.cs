using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Response
{
    /// <summary>
    /// ZhimaCreditOrderRepaymentApplyResponse.
    /// </summary>
    public class ZhimaCreditOrderRepaymentApplyResponse : AopResponse
    {
        /// <summary>
        /// 请求时传入外部单据号，结果中带回
        /// </summary>
        [XmlElement("out_order_no")]
        public string OutOrderNo { get; set; }

        /// <summary>
        /// 判断调用是否成功
        /// </summary>
        [XmlElement("success")]
        public bool Success { get; set; }
    }
}
