using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// KoubeiRetailWmsGoodssafetyinventoryModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiRetailWmsGoodssafetyinventoryModifyModel : AopObject
    {
        /// <summary>
        /// 货品安全库存
        /// </summary>
        [XmlArray("goods_safety_inventorys")]
        [XmlArrayItem("goods_safety_inventory")]
        public List<GoodsSafetyInventory> GoodsSafetyInventorys { get; set; }
    }
}
