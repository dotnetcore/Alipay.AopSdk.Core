using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// AlipayUserCertifyIdentifyVerifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayUserCertifyIdentifyVerifyModel : AopObject
    {
        /// <summary>
        /// 分配给业务的场景码
        /// </summary>
        [XmlElement("biz_code")]
        public string BizCode { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
