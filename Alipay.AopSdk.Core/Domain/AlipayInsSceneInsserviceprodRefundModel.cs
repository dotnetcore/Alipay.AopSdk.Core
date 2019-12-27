using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// AlipayInsSceneInsserviceprodRefundModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayInsSceneInsserviceprodRefundModel : AopObject
    {
        /// <summary>
        /// 服务订单号
        /// </summary>
        [XmlElement("order_no")]
        public string OrderNo { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
