using System.Collections.Generic;
using System.Xml.Serialization;
using Alipay.AopSdk.Core.Domain;

namespace Alipay.AopSdk.Core.Response
{
    /// <summary>
    /// AlipayCommerceCityfacilitatorVoucherBatchqueryResponse.
    /// </summary>
    public class AlipayCommerceCityfacilitatorVoucherBatchqueryResponse : AopResponse
    {
        /// <summary>
        /// 查询到的订单信息列表
        /// </summary>
        [XmlArray("tickets")]
        [XmlArrayItem("ticket_detail_info")]
        public List<TicketDetailInfo> Tickets { get; set; }
    }
}
