using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// MybankCreditLoantradeBillRepayCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class MybankCreditLoantradeBillRepayCreateModel : AopObject
    {
        /// <summary>
        /// 账单编号
        /// </summary>
        [XmlElement("bill_no")]
        public string BillNo { get; set; }

        /// <summary>
        /// 账单还款请求详情
        /// </summary>
        [XmlElement("bill_repay_request")]
        public BillRepayRequest BillRepayRequest { get; set; }

        /// <summary>
        /// 外部请求号
        /// </summary>
        [XmlElement("out_request_no")]
        public string OutRequestNo { get; set; }

        /// <summary>
        /// 必填，网商结算户的卡号外标
        /// </summary>
        [XmlElement("pay_card_no")]
        public string PayCardNo { get; set; }

        /// <summary>
        /// 方案合约编号
        /// </summary>
        [XmlElement("product_code")]
        public string ProductCode { get; set; }

        /// <summary>
        /// 用户信息
        /// </summary>
        [XmlElement("user")]
        public UserVo User { get; set; }
    }
}
