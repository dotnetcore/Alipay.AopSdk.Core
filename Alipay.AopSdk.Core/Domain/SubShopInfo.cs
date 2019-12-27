using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// SubShopInfo Data Structure.
    /// </summary>
    [Serializable]
    public class SubShopInfo : AopObject
    {
        /// <summary>
        /// 门店信息集合
        /// </summary>
        [XmlArray("shop_list")]
        [XmlArrayItem("shop")]
        public List<Shop> ShopList { get; set; }
    }
}
