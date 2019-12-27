using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// AntMerchantExpandActivityQualificationQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AntMerchantExpandActivityQualificationQueryModel : AopObject
    {
        /// <summary>
        /// 商家活动平台活动编码
        /// </summary>
        [XmlElement("activity_code")]
        public string ActivityCode { get; set; }

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
        /// 蚂蚁统一会员ID
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
