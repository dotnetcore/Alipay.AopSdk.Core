using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// AlipayCommerceIotDapplyRefundConfirmModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceIotDapplyRefundConfirmModel : AopObject
    {
        /// <summary>
        /// 物料申请单号
        /// </summary>
        [XmlElement("asset_apply_order_id")]
        public string AssetApplyOrderId { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        [XmlElement("memo")]
        public string Memo { get; set; }
    }
}
