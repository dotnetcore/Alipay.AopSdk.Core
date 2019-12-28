using System;
using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Domain
{
	/// <summary>
	///     AlipayCommerceCityfacilitatorVoucherQueryModel Data Structure.
	/// </summary>
	[Serializable]
	public class AlipayCommerceCityfacilitatorVoucherQueryModel : AopObject
	{
		/// <summary>
		///     城市标准码
		/// </summary>
		[JsonProperty("city_code")]
		public string CityCode { get; set; }

		/// <summary>
		///     8位核销码
		/// </summary>
		[JsonProperty("ticket_no")]
		public string TicketNo { get; set; }

		/// <summary>
		///     支付宝交易号
		/// </summary>
		[JsonProperty("trade_no")]
		public string TradeNo { get; set; }
	}
}