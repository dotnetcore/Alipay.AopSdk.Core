using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// AlipayCommerceTransportOfflinepayTradeSettleModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceTransportOfflinepayTradeSettleModel : AopObject
    {
        /// <summary>
        /// 脱机交易列表
        /// </summary>
        [XmlArray("trade_list")]
        [XmlArrayItem("alipay_offline_trade")]
        public List<AlipayOfflineTrade> TradeList { get; set; }
    }
}
