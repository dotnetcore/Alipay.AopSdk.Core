using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// AlipayUserMemberGcwtaskQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayUserMemberGcwtaskQueryModel : AopObject
    {
        /// <summary>
        /// 蚂蚁统一会员ID，16位2088开头。
        /// </summary>
        [XmlElement("alipay_user_id")]
        public string AlipayUserId { get; set; }

        /// <summary>
        /// 应用id，固定值，用于识别相关调用方的应用来源
        /// </summary>
        [XmlElement("application_id")]
        public string ApplicationId { get; set; }
    }
}
