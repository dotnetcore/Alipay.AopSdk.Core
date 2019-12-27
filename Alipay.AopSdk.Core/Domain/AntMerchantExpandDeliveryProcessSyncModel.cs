using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// AntMerchantExpandDeliveryProcessSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AntMerchantExpandDeliveryProcessSyncModel : AopObject
    {
        /// <summary>
        /// 发货计划反馈信息
        /// </summary>
        [XmlElement("asset_delivery_process_info")]
        public AssetDeliveryProcessInfo AssetDeliveryProcessInfo { get; set; }
    }
}
