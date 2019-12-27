using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// AlipayOverseasRemitFundInitializeModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOverseasRemitFundInitializeModel : AopObject
    {
        /// <summary>
        /// 发端生成的单据号
        /// </summary>
        [XmlElement("bc_remit_id")]
        public string BcRemitId { get; set; }

        /// <summary>
        /// 区块链上需要做合规检查的mid
        /// </summary>
        [XmlElement("compliance_mid")]
        public string ComplianceMid { get; set; }

        /// <summary>
        /// 扩展信息
        /// </summary>
        [XmlElement("extend_info")]
        public string ExtendInfo { get; set; }

        /// <summary>
        /// 报价和路由信息
        /// </summary>
        [XmlElement("quote_route_info")]
        public string QuoteRouteInfo { get; set; }

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
        /// 収端用户信息
        /// </summary>
        [XmlElement("receiver_info")]
        public string ReceiverInfo { get; set; }

        /// <summary>
        /// 接收端的mid
        /// </summary>
        [XmlElement("receiver_mid")]
        public string ReceiverMid { get; set; }

        /// <summary>
        /// 汇款附言
        /// </summary>
        [XmlElement("remark")]
        public string Remark { get; set; }

        /// <summary>
        /// 汇款用途
        /// </summary>
        [XmlElement("remit_purpose")]
        public string RemitPurpose { get; set; }

        /// <summary>
        /// 汇款发起的时间
        /// </summary>
        [XmlElement("send_date")]
        public string SendDate { get; set; }

        /// <summary>
        /// 发端用户的地址
        /// </summary>
        [XmlElement("sender_address")]
        public string SenderAddress { get; set; }

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
        /// 发端用户的用户id
        /// </summary>
        [XmlElement("sender_id")]
        public string SenderId { get; set; }

        /// <summary>
        /// 发端用户信息
        /// </summary>
        [XmlElement("sender_info")]
        public string SenderInfo { get; set; }

        /// <summary>
        /// 发端的mid
        /// </summary>
        [XmlElement("sender_mid")]
        public string SenderMid { get; set; }

        /// <summary>
        /// 发端用户的国籍
        /// </summary>
        [XmlElement("sender_nationality")]
        public string SenderNationality { get; set; }

        /// <summary>
        /// 交易币种
        /// </summary>
        [XmlElement("trans_currency")]
        public string TransCurrency { get; set; }
    }
}
