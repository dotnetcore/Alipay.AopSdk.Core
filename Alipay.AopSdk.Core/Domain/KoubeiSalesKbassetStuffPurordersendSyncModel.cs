using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// KoubeiSalesKbassetStuffPurordersendSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiSalesKbassetStuffPurordersendSyncModel : AopObject
    {
        /// <summary>
        /// 供应商同步的发货信息及物流信息记录（最多100条）
        /// </summary>
        [XmlArray("purchase_order_sends")]
        [XmlArrayItem("access_purchase_order_send")]
        public List<AccessPurchaseOrderSend> PurchaseOrderSends { get; set; }
    }
}
