using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// AlipayOverseasRemitFundTransferModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOverseasRemitFundTransferModel : AopObject
    {
        /// <summary>
        /// 汇率的基准币种
        /// </summary>
        [XmlElement("base_currency")]
        public string BaseCurrency { get; set; }

        /// <summary>
        /// 发端生成的单据号
        /// </summary>
        [XmlElement("bc_remit_id")]
        public string BcRemitId { get; set; }

        /// <summary>
        /// 汇率
        /// </summary>
        [XmlElement("exchange_rate")]
        public string ExchangeRate { get; set; }

        /// <summary>
        /// 收端用户收到的金额
        /// </summary>
        [XmlElement("receiver_amount")]
        public string ReceiverAmount { get; set; }

        /// <summary>
        /// 收端用户收到的金额币种
        /// </summary>
        [XmlElement("receiver_currency")]
        public string ReceiverCurrency { get; set; }

        /// <summary>
        /// 接收端的mid
        /// </summary>
        [XmlElement("receiver_mid")]
        public string ReceiverMid { get; set; }

        /// <summary>
        /// 发端用户的金额
        /// </summary>
        [XmlElement("sender_amount")]
        public string SenderAmount { get; set; }

        /// <summary>
        /// 发端用户金额的币种
        /// </summary>
        [XmlElement("sender_currency")]
        public string SenderCurrency { get; set; }

        /// <summary>
        /// 发端的mid
        /// </summary>
        [XmlElement("sender_mid")]
        public string SenderMid { get; set; }
    }
}
