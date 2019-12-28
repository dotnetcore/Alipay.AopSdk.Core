using System.Collections.Generic;
using Newtonsoft.Json;
using Alipay.AopSdk.Core.Domain;

namespace Alipay.AopSdk.Core.Response
{
	/// <summary>
	///     AlipayCommerceLotteryPresentlistQueryResponse.
	/// </summary>
	public class AlipayCommerceLotteryPresentlistQueryResponse : AopResponse
	{
		/// <summary>
		///     列表内容
		/// </summary>
		[JsonProperty("results")]
		
		public List<LotteryPresent> Results { get; set; }

		/// <summary>
		///     返回的列表的大小
		/// </summary>
		[JsonProperty("total_result")]
		public long TotalResult { get; set; }
	}
}