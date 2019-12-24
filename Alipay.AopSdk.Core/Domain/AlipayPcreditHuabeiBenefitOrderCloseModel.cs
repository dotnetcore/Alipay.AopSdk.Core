using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// AlipayPcreditHuabeiBenefitOrderCloseModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayPcreditHuabeiBenefitOrderCloseModel : AopObject
    {
        /// <summary>
        /// 支付宝用户id
        /// </summary>
        [XmlElement("alipay_user_id")]
        public string AlipayUserId { get; set; }

        /// <summary>
        /// 商户端业务发生时间(yyyy-MM-dd HH:mm:ss)
        /// </summary>
        [XmlElement("biz_time")]
        public string BizTime { get; set; }

        /// <summary>
        /// 权益订单id
        /// </summary>
        [XmlElement("order_id")]
        public string OrderId { get; set; }

        /// <summary>
        /// 商户请求场景
        /// </summary>
        [XmlElement("scene")]
        public string Scene { get; set; }
    }
}
