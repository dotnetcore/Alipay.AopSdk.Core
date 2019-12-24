using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// KoubeiRetailTopinstanceQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiRetailTopinstanceQueryModel : AopObject
    {
        /// <summary>
        /// 券或者电子DM单（VOUCHER、DM）
        /// </summary>
        [XmlElement("instance_type")]
        public string InstanceType { get; set; }
    }
}
