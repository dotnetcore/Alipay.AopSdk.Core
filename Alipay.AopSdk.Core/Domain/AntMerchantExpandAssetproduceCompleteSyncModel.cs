using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// AntMerchantExpandAssetproduceCompleteSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AntMerchantExpandAssetproduceCompleteSyncModel : AopObject
    {
        /// <summary>
        /// 物料生产单完成后指定物流信息
        /// </summary>
        [XmlArray("asset_produce_details")]
        [XmlArrayItem("item_delivery_detail")]
        public List<ItemDeliveryDetail> AssetProduceDetails { get; set; }
    }
}
