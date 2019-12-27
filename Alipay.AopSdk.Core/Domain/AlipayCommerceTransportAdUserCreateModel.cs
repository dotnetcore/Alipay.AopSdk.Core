using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// AlipayCommerceTransportAdUserCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceTransportAdUserCreateModel : AopObject
    {
        /// <summary>
        /// 广告主用户信息，参见文档
        /// </summary>
        [XmlElement("ad_user")]
        public AdUser AdUser { get; set; }
    }
}
