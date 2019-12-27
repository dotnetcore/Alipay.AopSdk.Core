using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// AlipayUserInvitetaskExchangeConfirmModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayUserInvitetaskExchangeConfirmModel : AopObject
    {
        /// <summary>
        /// 猫超券兑换金额,单位:分
        /// </summary>
        [XmlElement("exchange_amount_money")]
        public string ExchangeAmountMoney { get; set; }

        /// <summary>
        /// 兑换类型：PRODUCT/实物商品；TMALL_COUPON/猫超券
        /// </summary>
        [XmlElement("exchange_type")]
        public string ExchangeType { get; set; }

        /// <summary>
        /// 订单号
        /// </summary>
        [XmlElement("order_id")]
        public string OrderId { get; set; }

        /// <summary>
        /// 比如某种业务标准外部订单号,比如交易外部订单号，代表商户端自己订单号
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 兑换商品item_id
        /// </summary>
        [XmlElement("product_id")]
        public string ProductId { get; set; }

        /// <summary>
        /// 邀请任务进程业务号
        /// </summary>
        [XmlElement("task_process_id")]
        public string TaskProcessId { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
