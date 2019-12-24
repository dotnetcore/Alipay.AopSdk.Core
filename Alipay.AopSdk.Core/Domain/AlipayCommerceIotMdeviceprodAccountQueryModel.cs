using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// AlipayCommerceIotMdeviceprodAccountQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceIotMdeviceprodAccountQueryModel : AopObject
    {
        /// <summary>
        /// 登录ID，需要跟登录类别（logon_type，EMAIL:邮箱登陆 MOBILE:手机登录）结合
        /// </summary>
        [XmlElement("logon_id")]
        public string LogonId { get; set; }
    }
}
