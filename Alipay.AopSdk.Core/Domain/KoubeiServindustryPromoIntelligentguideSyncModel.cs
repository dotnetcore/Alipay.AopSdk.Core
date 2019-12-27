using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// KoubeiServindustryPromoIntelligentguideSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiServindustryPromoIntelligentguideSyncModel : AopObject
    {
        /// <summary>
        /// 商户ID
        /// </summary>
        [XmlElement("partner_id")]
        public string PartnerId { get; set; }

        /// <summary>
        /// 单商户下的门店交易数据列表
        /// </summary>
        [XmlArray("trade_infos")]
        [XmlArrayItem("intelligent_guide_trade_info")]
        public List<IntelligentGuideTradeInfo> TradeInfos { get; set; }
    }
}
