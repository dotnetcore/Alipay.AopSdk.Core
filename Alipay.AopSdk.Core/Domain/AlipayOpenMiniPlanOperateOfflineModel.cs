using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// AlipayOpenMiniPlanOperateOfflineModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenMiniPlanOperateOfflineModel : AopObject
    {
        /// <summary>
        /// 指定创建方案的 pid, 该字段仅白名单应用可用, 其他情况下会被忽略
        /// </summary>
        [XmlElement("pid")]
        public string Pid { get; set; }

        /// <summary>
        /// 已创建的支付后推荐方案id
        /// </summary>
        [XmlElement("plan_id")]
        public string PlanId { get; set; }
    }
}
