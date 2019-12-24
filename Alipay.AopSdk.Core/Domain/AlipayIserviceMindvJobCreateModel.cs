using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// AlipayIserviceMindvJobCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayIserviceMindvJobCreateModel : AopObject
    {
        /// <summary>
        /// 任务创建后发布的域名信息，枚举值:  ALIPAY(1, "surveys.alipay.com"),  ALIBABA_INC(2, "surveys.alibaba-inc.com"),  HEMAOS(3, "surveys.hemaos.com");
        /// </summary>
        [XmlElement("job_domain")]
        public string JobDomain { get; set; }

        /// <summary>
        /// 创建人工号
        /// </summary>
        [XmlElement("staff_no")]
        public string StaffNo { get; set; }

        /// <summary>
        /// 问卷/试卷标题信息
        /// </summary>
        [XmlElement("title")]
        public string Title { get; set; }

        /// <summary>
        /// 问卷/试卷类型区别. 枚举值: QUESTION-问卷, EXAM-试卷
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }
    }
}
