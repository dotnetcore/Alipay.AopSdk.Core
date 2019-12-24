using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// AlipayMerchantOrderUnlimitedQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMerchantOrderUnlimitedQueryModel : AopObject
    {
        /// <summary>
        /// 业务号（目前仅支持交易号）    注：order_id、biz_no两者必选其一，若用biz_no查询，必须传入buyer_id
        /// </summary>
        [XmlElement("biz_no")]
        public string BizNo { get; set; }

        /// <summary>
        /// 买家支付宝用户id    注：若用biz_no查询，必须传入buyer_id
        /// </summary>
        [XmlElement("buyer_id")]
        public string BuyerId { get; set; }

        /// <summary>
        /// 支付宝订单号（优先传入）  order_id、biz_no，两者必选其一；
        /// </summary>
        [XmlElement("order_id")]
        public string OrderId { get; set; }
    }
}
