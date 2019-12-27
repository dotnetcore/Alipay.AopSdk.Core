using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// AdUserQualification Data Structure.
    /// </summary>
    [Serializable]
    public class AdUserQualification : AopObject
    {
        /// <summary>
        /// 审核人员id
        /// </summary>
        [XmlElement("approver")]
        public string Approver { get; set; }

        /// <summary>
        /// 审核原因
        /// </summary>
        [XmlElement("audit_reason")]
        public string AuditReason { get; set; }

        /// <summary>
        /// 审核状态：0 审核通过、1 库存校验中、2运营审核中、3 审核拒绝
        /// </summary>
        [XmlElement("audit_status")]
        public long AuditStatus { get; set; }

        /// <summary>
        /// 审核日期
        /// </summary>
        [XmlElement("audit_time")]
        public long AuditTime { get; set; }

        /// <summary>
        /// 资质文件列表
        /// </summary>
        [XmlArray("file_url")]
        [XmlArrayItem("string")]
        public List<string> FileUrl { get; set; }

        /// <summary>
        /// 资质id
        /// </summary>
        [XmlElement("id")]
        public long Id { get; set; }

        /// <summary>
        /// 资质名称
        /// </summary>
        [XmlElement("qualification_name")]
        public string QualificationName { get; set; }
    }
}
