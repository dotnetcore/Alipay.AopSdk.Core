using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// AntMerchantExpandAssetreverseCompleteSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AntMerchantExpandAssetreverseCompleteSyncModel : AopObject
    {
        /// <summary>
        /// 取消订单或退货成功入参
        /// </summary>
        [XmlArray("asset_reverse_details")]
        [XmlArrayItem("asset_reverse_detail")]
        public List<AssetReverseDetail> AssetReverseDetails { get; set; }
    }
}
