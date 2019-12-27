using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// AlipayUserAgreementExecutionplanModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayUserAgreementExecutionplanModifyModel : AopObject
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

        /// <summary>
        /// 具体修改原因
        /// </summary>
        [XmlElement("memo")]
        public string Memo { get; set; }
    }
}
