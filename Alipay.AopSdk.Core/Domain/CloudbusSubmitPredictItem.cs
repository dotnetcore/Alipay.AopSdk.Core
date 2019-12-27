using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// CloudbusSubmitPredictItem Data Structure.
    /// </summary>
    [Serializable]
    public class CloudbusSubmitPredictItem : AopObject
    {
        /// <summary>
        /// 处理过程状态描述
        /// </summary>
        [XmlElement("message")]
        public string Message { get; set; }

        /// <summary>
        /// 任务计划
        /// </summary>
        [XmlElement("plan_id")]
        public string PlanId { get; set; }
    }
}
