using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// AuthInfo Data Structure.
    /// </summary>
    [Serializable]
    public class AuthInfo : AopObject
    {
        /// <summary>
        /// 授权号
        /// </summary>
        [XmlElement("auth_code")]
        public string AuthCode { get; set; }

        /// <summary>
        /// 授权类型
        /// </summary>
        [XmlElement("auth_type")]
        public string AuthType { get; set; }
    }
}
