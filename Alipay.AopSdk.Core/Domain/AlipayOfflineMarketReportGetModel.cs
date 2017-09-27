using System;
using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Domain
{
	/// <summary>
	///     AlipayOfflineMarketReportGetModel Data Structure.
	/// </summary>
	[Serializable]
	public class AlipayOfflineMarketReportGetModel : AopObject
	{
		/// <summary>
		///     操作人PID
		/// </summary>
		[JsonProperty("ope_pid")]
		public string OpePid { get; set; }

		/// <summary>
		///     全局唯一的流水号
		/// </summary>
		[JsonProperty("request_id")]
		public string RequestId { get; set; }

		/// <summary>
		///     门店id
		/// </summary>
		[JsonProperty("shop_id")]
		public string ShopId { get; set; }
	}
}