using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// AlipayMarketingVoucherStockMatchModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMarketingVoucherStockMatchModel : AopObject
    {
        /// <summary>
        /// 待核查券码列表，商户体系内可兑换使用的券码
        /// </summary>
        [XmlArray("entity_list")]
        [XmlArrayItem("string")]
        public List<string> EntityList { get; set; }

        /// <summary>
        /// 库存ID,创建库存时返回
        /// </summary>
        [XmlElement("stock_id")]
        public string StockId { get; set; }
    }
}
