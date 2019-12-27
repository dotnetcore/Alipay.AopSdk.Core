using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// AntMerchantExpandBenefitVerifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AntMerchantExpandBenefitVerifyModel : AopObject
    {
        /// <summary>
        /// 业务扩展信息
        /// </summary>
        [XmlElement("biz_ext")]
        public string BizExt { get; set; }

        /// <summary>
        /// 外部业务时间
        /// </summary>
        [XmlElement("out_biz_time")]
        public string OutBizTime { get; set; }

        /// <summary>
        /// 外部用户ID
        /// </summary>
        [XmlElement("out_user_id")]
        public string OutUserId { get; set; }

        /// <summary>
        /// 权益发放记录ID
        /// </summary>
        [XmlElement("record_id")]
        public string RecordId { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
