using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Response
{
    /// <summary>
    /// KoubeiTradeKbdeliveryDeliveryCancelResponse.
    /// </summary>
    public class KoubeiTradeKbdeliveryDeliveryCancelResponse : AopResponse
    {
        /// <summary>
        /// 成功关闭时间，时间格式:  yyyyMMddHHmmss
        /// </summary>
        [XmlElement("gmt_close")]
        public string GmtClose { get; set; }

        /// <summary>
        /// 口碑物流单号
        /// </summary>
        [XmlElement("logistics_order_no")]
        public string LogisticsOrderNo { get; set; }
    }
}
