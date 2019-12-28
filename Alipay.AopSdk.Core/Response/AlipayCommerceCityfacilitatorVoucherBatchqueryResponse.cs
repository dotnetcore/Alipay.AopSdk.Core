using System.Collections.Generic;
using Newtonsoft.Json;
using Alipay.AopSdk.Core.Domain;

namespace Alipay.AopSdk.Core.Response
{
	/// <summary>
	///     AlipayCommerceCityfacilitatorVoucherBatchqueryResponse.
	/// </summary>
	public class AlipayCommerceCityfacilitatorVoucherBatchqueryResponse : AopResponse
	{
		/// <summary>
		///     查询到的订单信息列表
		/// </summary>
		[JsonProperty("tickets")]
		
		public List<TicketDetailInfo> Tickets { get; set; }
	}
}