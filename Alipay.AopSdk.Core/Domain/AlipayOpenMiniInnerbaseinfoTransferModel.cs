using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// AlipayOpenMiniInnerbaseinfoTransferModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenMiniInnerbaseinfoTransferModel : AopObject
    {
        /// <summary>
        /// 应用来源
        /// </summary>
        [XmlElement("app_origin")]
        public string AppOrigin { get; set; }

        /// <summary>
        /// 支付宝登陆账号
        /// </summary>
        [XmlElement("login_id")]
        public string LoginId { get; set; }

        /// <summary>
        /// 需要迁移的小程序ID
        /// </summary>
        [XmlElement("mini_app_id")]
        public string MiniAppId { get; set; }

        /// <summary>
        /// 应用主体
        /// </summary>
        [XmlElement("owner_entity")]
        public string OwnerEntity { get; set; }

        /// <summary>
        /// 应用来源  MAYI：蚂蚁域内应用  ALIBABA：阿里域内应用
        /// </summary>
        [XmlElement("partner_domain")]
        public string PartnerDomain { get; set; }

        /// <summary>
        /// 用户id
        /// </summary>
        [XmlElement("pid")]
        public string Pid { get; set; }
    }
}
