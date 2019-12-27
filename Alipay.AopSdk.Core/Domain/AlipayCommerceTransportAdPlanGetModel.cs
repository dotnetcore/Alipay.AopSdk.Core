using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// AlipayCommerceTransportAdPlanGetModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceTransportAdPlanGetModel : AopObject
    {
        /// <summary>
        /// 广告系统的用户ID
        /// </summary>
        [XmlElement("ad_user_id")]
        public long AdUserId { get; set; }

        /// <summary>
        /// 通过API新建计划，获得的计划ID
        /// </summary>
        [XmlElement("plan_id")]
        public long PlanId { get; set; }
    }
}
