using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// AlipayUserAuthSecondpartyTokenVerifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayUserAuthSecondpartyTokenVerifyModel : AopObject
    {
        /// <summary>
        /// 二方登录token
        /// </summary>
        [XmlElement("second_party_token")]
        public string SecondPartyToken { get; set; }

        /// <summary>
        /// 渠道来源
        /// </summary>
        [XmlElement("source")]
        public string Source { get; set; }
    }
}
