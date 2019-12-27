using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// ArchiveFaceExtInfo Data Structure.
    /// </summary>
    [Serializable]
    public class ArchiveFaceExtInfo : AopObject
    {
        /// <summary>
        /// 证件提供者的支付宝uid
        /// </summary>
        [XmlElement("provider_uid")]
        public string ProviderUid { get; set; }
    }
}
