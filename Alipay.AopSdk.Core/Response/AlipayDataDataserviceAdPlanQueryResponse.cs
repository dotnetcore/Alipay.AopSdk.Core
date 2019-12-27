using System.Xml.Serialization;
using Alipay.AopSdk.Core.Domain;

namespace Alipay.AopSdk.Core.Response
{
    /// <summary>
    /// AlipayDataDataserviceAdPlanQueryResponse.
    /// </summary>
    public class AlipayDataDataserviceAdPlanQueryResponse : AopResponse
    {
        /// <summary>
        /// 计划详情
        /// </summary>
        [XmlElement("plan_detail")]
        public OuterPlan PlanDetail { get; set; }
    }
}
