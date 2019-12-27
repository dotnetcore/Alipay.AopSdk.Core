using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// AlipayCommerceIotApplyorderStatusSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceIotApplyorderStatusSyncModel : AopObject
    {
        /// <summary>
        /// 申请单状态
        /// </summary>
        [XmlElement("apply_order_status")]
        public string ApplyOrderStatus { get; set; }

        /// <summary>
        /// 物料申请单号
        /// </summary>
        [XmlElement("asset_apply_order_id")]
        public string AssetApplyOrderId { get; set; }
    }
}
