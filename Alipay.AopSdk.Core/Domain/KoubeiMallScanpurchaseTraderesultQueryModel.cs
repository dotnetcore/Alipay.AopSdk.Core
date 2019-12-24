using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// KoubeiMallScanpurchaseTraderesultQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiMallScanpurchaseTraderesultQueryModel : AopObject
    {
        /// <summary>
        /// 说明渠道，口碑app为 APP,  口碑tab 为TAB. 默认是TAB
        /// </summary>
        [XmlElement("channel")]
        public string Channel { get; set; }

        /// <summary>
        /// 支付宝交易号
        /// </summary>
        [XmlElement("trade_no")]
        public string TradeNo { get; set; }

        /// <summary>
        /// 买家用户id
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
