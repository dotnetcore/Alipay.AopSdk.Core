using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Response
{
    /// <summary>
    /// AlipayDataDataserviceAdPlanCreateormodifyResponse.
    /// </summary>
    public class AlipayDataDataserviceAdPlanCreateormodifyResponse : AopResponse
    {
        /// <summary>
        /// 计划id
        /// </summary>
        [XmlElement("plan_id")]
        public long PlanId { get; set; }

        /// <summary>
        /// 外部计划编号。同入参的同名字段。
        /// </summary>
        [XmlElement("plan_outer_id")]
        public string PlanOuterId { get; set; }
    }
}
