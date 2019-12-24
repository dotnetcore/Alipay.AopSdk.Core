using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// AlipayIserviceMindvJobsbyuserQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayIserviceMindvJobsbyuserQueryModel : AopObject
    {
        /// <summary>
        /// 对应账号类型下的唯一账号主键_用以区分对应的填写用户
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }

        /// <summary>
        /// 账号类型_用以区分不同账号体系的用户    ALIPAY-支付宝  HEMA-盒马  ALIBABA_INC-内部域账号
        /// </summary>
        [XmlElement("user_type")]
        public string UserType { get; set; }
    }
}
