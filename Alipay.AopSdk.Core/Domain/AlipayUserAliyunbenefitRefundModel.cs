using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// AlipayUserAliyunbenefitRefundModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayUserAliyunbenefitRefundModel : AopObject
    {
        /// <summary>
        /// 业务流水号，用来映射需要回退积分的订单号，与权益兑换时传入的值一致。
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 订单所属支付宝用户的uid，与兑换接口中传入的值保持一致
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
