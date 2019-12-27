using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// InvalidTradeDetail Data Structure.
    /// </summary>
    [Serializable]
    public class InvalidTradeDetail : AopObject
    {
        /// <summary>
        /// 错误信息，用于描述单条交易数据错误原因
        /// </summary>
        [XmlElement("error_message")]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// 商户口碑门店id
        /// </summary>
        [XmlElement("shop_id")]
        public string ShopId { get; set; }

        /// <summary>
        /// 商户门店名称
        /// </summary>
        [XmlElement("shop_name")]
        public string ShopName { get; set; }

        /// <summary>
        /// 商户单门店下线下交易数据详细信息
        /// </summary>
        [XmlElement("trade_detail")]
        public IntelligentGuideTradeDetail TradeDetail { get; set; }
    }
}
