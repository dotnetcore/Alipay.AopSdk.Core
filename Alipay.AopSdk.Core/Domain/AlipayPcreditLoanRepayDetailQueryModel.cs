using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// AlipayPcreditLoanRepayDetailQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayPcreditLoanRepayDetailQueryModel : AopObject
    {
        /// <summary>
        /// 贷款申请受理单号，与外部业务单号二者不能同时为空
        /// </summary>
        [XmlElement("apply_receipt_no")]
        public string ApplyReceiptNo { get; set; }

        /// <summary>
        /// 查询还款流水明细截止时间
        /// </summary>
        [XmlElement("end_date")]
        public string EndDate { get; set; }

        /// <summary>
        /// 外部业务单号，与贷款申请受理单号二者不能同时为空
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 代表了一次请求，作为业务幂等性控制
        /// </summary>
        [XmlElement("out_request_no")]
        public string OutRequestNo { get; set; }

        /// <summary>
        /// 查询还款流水明细起始时间
        /// </summary>
        [XmlElement("start_date")]
        public string StartDate { get; set; }
    }
}
