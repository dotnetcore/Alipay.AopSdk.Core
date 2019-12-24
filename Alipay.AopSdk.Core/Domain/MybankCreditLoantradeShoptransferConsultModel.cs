using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// MybankCreditLoantradeShoptransferConsultModel Data Structure.
    /// </summary>
    [Serializable]
    public class MybankCreditLoantradeShoptransferConsultModel : AopObject
    {
        /// <summary>
        /// 咨询业务类型,TRANSFER(转让)/RECEIVE(接收)
        /// </summary>
        [XmlElement("biz_type")]
        public string BizType { get; set; }

        /// <summary>
        /// 接收方支付宝id
        /// </summary>
        [XmlElement("receive_alipay_id")]
        public string ReceiveAlipayId { get; set; }

        /// <summary>
        /// 淘宝userId
        /// </summary>
        [XmlElement("taobao_id")]
        public string TaobaoId { get; set; }

        /// <summary>
        /// 转让流程编号
        /// </summary>
        [XmlElement("trans_no")]
        public string TransNo { get; set; }

        /// <summary>
        /// 转让方支付宝id
        /// </summary>
        [XmlElement("transfer_alipay_id")]
        public string TransferAlipayId { get; set; }
    }
}
