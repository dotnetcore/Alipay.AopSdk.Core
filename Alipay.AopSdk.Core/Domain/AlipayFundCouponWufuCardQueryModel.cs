using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// AlipayFundCouponWufuCardQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayFundCouponWufuCardQueryModel : AopObject
    {
        /// <summary>
        /// 业务场景码
        /// </summary>
        [XmlElement("scene")]
        public string Scene { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
