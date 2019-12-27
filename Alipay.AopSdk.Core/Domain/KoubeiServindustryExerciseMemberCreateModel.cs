using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// KoubeiServindustryExerciseMemberCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiServindustryExerciseMemberCreateModel : AopObject
    {
        /// <summary>
        /// 外部会籍id
        /// </summary>
        [XmlElement("external_member_id")]
        public string ExternalMemberId { get; set; }

        /// <summary>
        /// 健身用户id
        /// </summary>
        [XmlElement("fitness_id")]
        public string FitnessId { get; set; }

        /// <summary>
        /// 会籍的到期时间
        /// </summary>
        [XmlElement("gmt_end")]
        public string GmtEnd { get; set; }

        /// <summary>
        /// 会籍的开始时间
        /// </summary>
        [XmlElement("gmt_start")]
        public string GmtStart { get; set; }

        /// <summary>
        /// 会籍级别
        /// </summary>
        [XmlElement("level")]
        public string Level { get; set; }

        /// <summary>
        /// 会籍名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 商户ID
        /// </summary>
        [XmlElement("parent_id")]
        public string ParentId { get; set; }

        /// <summary>
        /// 外部请求ID
        /// </summary>
        [XmlElement("request_id")]
        public string RequestId { get; set; }

        /// <summary>
        /// 适用的口碑门店id或商户列表
        /// </summary>
        [XmlArray("subject_id_list")]
        [XmlArrayItem("string")]
        public List<string> SubjectIdList { get; set; }

        /// <summary>
        /// 关联类型
        /// </summary>
        [XmlElement("subject_type")]
        public string SubjectType { get; set; }

        /// <summary>
        /// 口碑的用户id
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
