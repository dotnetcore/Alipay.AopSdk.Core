using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// KoubeiMerchantKbcloudSubuserinfoQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiMerchantKbcloudSubuserinfoQueryModel : AopObject
    {
        /// <summary>
        /// 主账号ID
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
