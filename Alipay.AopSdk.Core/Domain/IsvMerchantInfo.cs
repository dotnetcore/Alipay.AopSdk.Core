using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// IsvMerchantInfo Data Structure.
    /// </summary>
    [Serializable]
    public class IsvMerchantInfo : AopObject
    {
        /// <summary>
        /// 商户pid
        /// </summary>
        [XmlElement("partner_id")]
        public string PartnerId { get; set; }

        /// <summary>
        /// 门店ID列表
        /// </summary>
        [XmlArray("shop_ids")]
        [XmlArrayItem("string")]
        public List<string> ShopIds { get; set; }
    }
}
