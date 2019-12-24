using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// TradeSettleInfo Data Structure.
    /// </summary>
    [Serializable]
    public class TradeSettleInfo : AopObject
    {
        /// <summary>
        /// 交易结算明细信息
        /// </summary>
        [XmlArray("trade_settle_detail_list")]
        [XmlArrayItem("trade_settle_detail")]
        public List<TradeSettleDetail> TradeSettleDetailList { get; set; }
    }
}
