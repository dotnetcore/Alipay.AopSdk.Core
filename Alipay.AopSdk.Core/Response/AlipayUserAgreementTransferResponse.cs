using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Response
{
    /// <summary>
    /// AlipayUserAgreementTransferResponse.
    /// </summary>
    public class AlipayUserAgreementTransferResponse : AopResponse
    {
        /// <summary>
        /// 单次金额限制
        /// </summary>
        [XmlElement("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// 执行时间
        /// </summary>
        [XmlElement("execute_time")]
        public string ExecuteTime { get; set; }

        /// <summary>
        /// 周期
        /// </summary>
        [XmlElement("period")]
        public string Period { get; set; }

        /// <summary>
        /// 周期类型
        /// </summary>
        [XmlElement("period_type")]
        public string PeriodType { get; set; }

        /// <summary>
        /// 总金额限制
        /// </summary>
        [XmlElement("total_amount")]
        public string TotalAmount { get; set; }

        /// <summary>
        /// 总支付次数
        /// </summary>
        [XmlElement("total_payments")]
        public string TotalPayments { get; set; }
    }
}
