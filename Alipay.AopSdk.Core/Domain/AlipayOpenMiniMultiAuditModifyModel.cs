using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// AlipayOpenMiniMultiAuditModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenMiniMultiAuditModifyModel : AopObject
    {
        /// <summary>
        /// 审核备注
        /// </summary>
        [XmlElement("memo")]
        public string Memo { get; set; }

        /// <summary>
        /// 处理动作agree/reject
        /// </summary>
        [XmlElement("operate_result")]
        public string OperateResult { get; set; }

        /// <summary>
        /// 操作类型，高德固定填写AMAP_AUDIT_CALL_BACK
        /// </summary>
        [XmlElement("operate_type")]
        public string OperateType { get; set; }

        /// <summary>
        /// 工单id
        /// </summary>
        [XmlElement("task_id")]
        public string TaskId { get; set; }
    }
}
