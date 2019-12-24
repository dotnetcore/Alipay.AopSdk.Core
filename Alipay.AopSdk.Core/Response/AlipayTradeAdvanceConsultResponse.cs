using System.Collections.Generic;
using System.Xml.Serialization;
using Alipay.AopSdk.Core.Domain;

namespace Alipay.AopSdk.Core.Response
{
    /// <summary>
    /// AlipayTradeAdvanceConsultResponse.
    /// </summary>
    public class AlipayTradeAdvanceConsultResponse : AopResponse
    {
        /// <summary>
        /// true 代表当前时间点，用户允许垫资 false 代表当前时间，用户不允许垫资
        /// </summary>
        [XmlElement("refer_result")]
        public bool ReferResult { get; set; }

        /// <summary>
        /// 用户被注销
        /// </summary>
        [XmlElement("result_code")]
        public string ResultCode { get; set; }

        /// <summary>
        /// 返回用户不准入原因
        /// </summary>
        [XmlElement("result_message")]
        public string ResultMessage { get; set; }

        /// <summary>
        /// 用户剩余的总待还金额，无论当前用户是否允许垫资，都会返回改属性
        /// </summary>
        [XmlElement("wait_repayment_amount")]
        public string WaitRepaymentAmount { get; set; }

        /// <summary>
        /// 用户总的未还的垫资笔数，无论用户是否允许垫资，都会返回该属性
        /// </summary>
        [XmlElement("wait_repayment_order_count")]
        public long WaitRepaymentOrderCount { get; set; }

        /// <summary>
        /// 待还订单列表，无论用户当前状态是否允许垫资，都会返回当前用户在商户下的待还订单信息
        /// </summary>
        [XmlArray("wait_repayment_order_infos")]
        [XmlArrayItem("wait_repayment_order_info")]
        public List<WaitRepaymentOrderInfo> WaitRepaymentOrderInfos { get; set; }
    }
}
