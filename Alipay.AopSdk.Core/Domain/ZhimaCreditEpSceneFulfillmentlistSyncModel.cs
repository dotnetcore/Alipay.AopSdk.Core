using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// ZhimaCreditEpSceneFulfillmentlistSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class ZhimaCreditEpSceneFulfillmentlistSyncModel : AopObject
    {
        /// <summary>
        /// 信用订单号，即调用zhima.credit.ep.scene.agreement.use返回的信用订单号。
        /// </summary>
        [XmlElement("credit_order_no")]
        public string CreditOrderNo { get; set; }

        /// <summary>
        /// 履约信息列表，最大不超过200项
        /// </summary>
        [XmlArray("fulfillment_info_list")]
        [XmlArrayItem("fulfillment_info")]
        public List<FulfillmentInfo> FulfillmentInfoList { get; set; }
    }
}
