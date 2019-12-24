using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// AlipayOpenMiniSafedomainDeleteModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenMiniSafedomainDeleteModel : AopObject
    {
        /// <summary>
        /// httpRequest域白名单
        /// </summary>
        [XmlElement("safe_domain")]
        public string SafeDomain { get; set; }
    }
}
