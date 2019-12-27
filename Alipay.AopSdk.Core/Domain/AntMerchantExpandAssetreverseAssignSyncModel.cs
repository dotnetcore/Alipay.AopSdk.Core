using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// AntMerchantExpandAssetreverseAssignSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AntMerchantExpandAssetreverseAssignSyncModel : AopObject
    {
        /// <summary>
        /// 取消订单或退货指令接收反馈，最多200条
        /// </summary>
        [XmlArray("reverse_results")]
        [XmlArrayItem("asset_result")]
        public List<AssetResult> ReverseResults { get; set; }
    }
}
