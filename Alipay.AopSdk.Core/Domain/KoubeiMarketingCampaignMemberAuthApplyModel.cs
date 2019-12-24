using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// KoubeiMarketingCampaignMemberAuthApplyModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiMarketingCampaignMemberAuthApplyModel : AopObject
    {
        /// <summary>
        /// token
        /// </summary>
        [XmlElement("auth_token")]
        public string AuthToken { get; set; }
    }
}
