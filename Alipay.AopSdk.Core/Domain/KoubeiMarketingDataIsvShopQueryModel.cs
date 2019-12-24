using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// KoubeiMarketingDataIsvShopQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiMarketingDataIsvShopQueryModel : AopObject
    {
        /// <summary>
        /// 门店ID列表（单次最多查询100个门店）
        /// </summary>
        [XmlArray("shop_ids")]
        [XmlArrayItem("string")]
        public List<string> ShopIds { get; set; }
    }
}
