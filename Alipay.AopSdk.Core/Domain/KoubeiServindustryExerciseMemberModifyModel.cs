using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// KoubeiServindustryExerciseMemberModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiServindustryExerciseMemberModifyModel : AopObject
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
        /// 会籍的到期时间 注：name与会籍的到期时间两个可选字段至少传一个
        /// </summary>
        [XmlElement("gmt_end")]
        public string GmtEnd { get; set; }

        /// <summary>
        /// 口碑的会籍id
        /// </summary>
        [XmlElement("member_id")]
        public string MemberId { get; set; }

        /// <summary>
        /// 会籍名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 外部请求id
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
        /// 新增或者删除关联类型，注：ADD=新增，DELETE=删除
        /// </summary>
        [XmlElement("subject_operate_type")]
        public string SubjectOperateType { get; set; }

        /// <summary>
        /// 关联类型，店铺(MEMBER_SHOP)，商户（MEMBER_PARTNER）
        /// </summary>
        [XmlElement("subject_type")]
        public string SubjectType { get; set; }
    }
}
