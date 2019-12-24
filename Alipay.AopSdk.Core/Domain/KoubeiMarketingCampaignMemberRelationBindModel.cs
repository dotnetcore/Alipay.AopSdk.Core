using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// KoubeiMarketingCampaignMemberRelationBindModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiMarketingCampaignMemberRelationBindModel : AopObject
    {
        /// <summary>
        /// 会员开通时间
        /// </summary>
        [XmlElement("activate_time")]
        public string ActivateTime { get; set; }

        /// <summary>
        /// 余额
        /// </summary>
        [XmlElement("balance")]
        public string Balance { get; set; }

        /// <summary>
        /// 生日
        /// </summary>
        [XmlElement("birth")]
        public string Birth { get; set; }

        /// <summary>
        /// 手机号
        /// </summary>
        [XmlElement("cell")]
        public string Cell { get; set; }

        /// <summary>
        /// 会员过期时间
        /// </summary>
        [XmlElement("end_time")]
        public string EndTime { get; set; }

        /// <summary>
        /// 性别
        /// </summary>
        [XmlElement("gender")]
        public string Gender { get; set; }

        /// <summary>
        /// 会员等级
        /// </summary>
        [XmlElement("level")]
        public long Level { get; set; }

        /// <summary>
        /// 会员模版id
        /// </summary>
        [XmlElement("member_template_id")]
        public string MemberTemplateId { get; set; }

        /// <summary>
        /// 商户外部会员号
        /// </summary>
        [XmlElement("out_member_no")]
        public string OutMemberNo { get; set; }

        /// <summary>
        /// 积分
        /// </summary>
        [XmlElement("point")]
        public string Point { get; set; }

        /// <summary>
        /// 外部请求幂等号
        /// </summary>
        [XmlElement("request_id")]
        public string RequestId { get; set; }

        /// <summary>
        /// 会员开始时间
        /// </summary>
        [XmlElement("start_time")]
        public string StartTime { get; set; }

        /// <summary>
        /// 用户id
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }

        /// <summary>
        /// 姓名
        /// </summary>
        [XmlElement("user_name")]
        public string UserName { get; set; }
    }
}
