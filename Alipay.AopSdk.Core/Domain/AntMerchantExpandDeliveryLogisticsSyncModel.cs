using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// AntMerchantExpandDeliveryLogisticsSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AntMerchantExpandDeliveryLogisticsSyncModel : AopObject
    {
        /// <summary>
        /// 配送指令
        /// </summary>
        [XmlElement("assign_item_id")]
        public string AssignItemId { get; set; }

        /// <summary>
        /// 物流信息
        /// </summary>
        [XmlElement("logistics_info")]
        public LogisticsInfo LogisticsInfo { get; set; }
    }
}
