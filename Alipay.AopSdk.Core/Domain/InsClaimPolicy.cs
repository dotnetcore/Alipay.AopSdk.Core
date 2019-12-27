using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// InsClaimPolicy Data Structure.
    /// </summary>
    [Serializable]
    public class InsClaimPolicy : AopObject
    {
        /// <summary>
        /// 保单号
        /// </summary>
        [XmlElement("policy_no")]
        public string PolicyNo { get; set; }
    }
}
