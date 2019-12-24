using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// AlipayOpenMiniAppinfoQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenMiniAppinfoQueryModel : AopObject
    {
        /// <summary>
        /// 登录ID
        /// </summary>
        [XmlElement("logon_id")]
        public string LogonId { get; set; }

        /// <summary>
        /// 应用类型（MINIAPP-小程序，LIEFAPP-生活号）
        /// </summary>
        [XmlElement("open_app_type")]
        public string OpenAppType { get; set; }
    }
}
