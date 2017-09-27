using System.Collections.Generic;
using Newtonsoft.Json;
using Alipay.AopSdk.Core.Domain;

namespace Alipay.AopSdk.Core.Response
{
	/// <summary>
	///     AlipayCommerceLotteryTypelistQueryResponse.
	/// </summary>
	public class AlipayCommerceLotteryTypelistQueryResponse : AopResponse
	{
		/// <summary>
		///     彩票系统支持的可用于赠送的彩种类型列表
		/// </summary>
		[JsonProperty("results")]
		
		public List<LotteryType> Results { get; set; }

		/// <summary>
		///     彩票系统支持的可用于赠送的彩种个数
		/// </summary>
		[JsonProperty("total_result")]
		public long TotalResult { get; set; }
	}
}