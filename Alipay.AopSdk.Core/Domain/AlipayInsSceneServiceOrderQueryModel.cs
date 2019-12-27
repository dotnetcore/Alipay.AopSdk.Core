using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// AlipayInsSceneServiceOrderQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayInsSceneServiceOrderQueryModel : AopObject
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
