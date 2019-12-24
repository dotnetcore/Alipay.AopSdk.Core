using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// CloudbusRetryPredictItem Data Structure.
    /// </summary>
    [Serializable]
    public class CloudbusRetryPredictItem : AopObject
    {
        /// <summary>
        /// 处理过程状态描述
        /// </summary>
        [XmlElement("message")]
        public string Message { get; set; }

        /// <summary>
        /// 重试任务计划
        /// </summary>
        [XmlElement("plan_id")]
        public string PlanId { get; set; }
    }
}
