using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Response
{
    /// <summary>
    /// AlipayUserAgreementExecutionplanModifyResponse.
    /// </summary>
    public class AlipayUserAgreementExecutionplanModifyResponse : AopResponse
    {
        /// <summary>
        /// 周期性扣款产品，授权免密支付协议号
        /// </summary>
        [XmlElement("agreement_no")]
        public string AgreementNo { get; set; }

        /// <summary>
        /// 商户下一次扣款时间
        /// </summary>
        [XmlElement("deduct_time")]
        public string DeductTime { get; set; }
    }
}
