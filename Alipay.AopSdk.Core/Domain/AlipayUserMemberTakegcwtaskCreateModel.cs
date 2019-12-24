using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// AlipayUserMemberTakegcwtaskCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayUserMemberTakegcwtaskCreateModel : AopObject
    {
        /// <summary>
        /// 蚂蚁统一会员ID，16位2088开头。
        /// </summary>
        [XmlElement("alipay_user_id")]
        public string AlipayUserId { get; set; }

        /// <summary>
        /// 应用id，固定值，用于识别相关调用方的应用来源
        /// </summary>
        [XmlElement("application_id")]
        public string ApplicationId { get; set; }

        /// <summary>
        /// 任务流水id，唯一值，用于双方幂等控制
        /// </summary>
        [XmlElement("flow_id")]
        public string FlowId { get; set; }

        /// <summary>
        /// 任务id
        /// </summary>
        [XmlElement("task_id")]
        public string TaskId { get; set; }
    }
}
