using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// AlipayOpenAuthAppContentQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenAuthAppContentQueryModel : AopObject
    {
        /// <summary>
        /// 授权场景，固定值PLATFORM_APP_AUTH
        /// </summary>
        [XmlElement("auth_scene")]
        public string AuthScene { get; set; }
    }
}
