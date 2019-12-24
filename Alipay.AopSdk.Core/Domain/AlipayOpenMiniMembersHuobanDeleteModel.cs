using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// AlipayOpenMiniMembersHuobanDeleteModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenMiniMembersHuobanDeleteModel : AopObject
    {
        /// <summary>
        /// 用户域账号
        /// </summary>
        [XmlElement("domain_account")]
        public string DomainAccount { get; set; }

        /// <summary>
        /// 支付宝账号
        /// </summary>
        [XmlElement("login_id")]
        public string LoginId { get; set; }

        /// <summary>
        /// 小程序ID
        /// </summary>
        [XmlElement("operate_app_id")]
        public string OperateAppId { get; set; }

        /// <summary>
        /// 成员角色
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }
    }
}
