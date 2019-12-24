using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// IntelligentGuideTradeInfo Data Structure.
    /// </summary>
    [Serializable]
    public class IntelligentGuideTradeInfo : AopObject
    {
        /// <summary>
        /// 商户在口碑侧的门店id，校验纯数字，28位
        /// </summary>
        [XmlElement("shop_id")]
        public string ShopId { get; set; }

        /// <summary>
        /// 商户门店名称
        /// </summary>
        [XmlElement("shop_name")]
        public string ShopName { get; set; }

        /// <summary>
        /// 单个门店下的具体交易信息列表
        /// </summary>
        [XmlArray("trade_details")]
        [XmlArrayItem("intelligent_guide_trade_detail")]
        public List<IntelligentGuideTradeDetail> TradeDetails { get; set; }
    }
}
