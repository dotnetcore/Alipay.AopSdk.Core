using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// AlipayMarketingVoucherStockQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMarketingVoucherStockQueryModel : AopObject
    {
        /// <summary>
        /// 库存ID, 库存创建接口返回
        /// </summary>
        [XmlElement("stock_id")]
        public string StockId { get; set; }
    }
}
