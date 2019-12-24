using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// AlipayCommerceTransportAdPlanCertifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceTransportAdPlanCertifyModel : AopObject
    {
        /// <summary>
        /// 广告系统用户ID
        /// </summary>
        [XmlElement("ad_user_id")]
        public long AdUserId { get; set; }

        /// <summary>
        /// 广告计划ID
        /// </summary>
        [XmlElement("plan_id")]
        public long PlanId { get; set; }
    }
}
