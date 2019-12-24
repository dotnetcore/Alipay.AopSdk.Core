using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// AlipayOpenStsTokenGetModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenStsTokenGetModel : AopObject
    {
        /// <summary>
        /// 当前安全令牌
        /// </summary>
        [XmlElement("security_token")]
        public string SecurityToken { get; set; }

        /// <summary>
        /// 终端运行环境信息
        /// </summary>
        [XmlElement("terminal")]
        public Terminal Terminal { get; set; }
    }
}
