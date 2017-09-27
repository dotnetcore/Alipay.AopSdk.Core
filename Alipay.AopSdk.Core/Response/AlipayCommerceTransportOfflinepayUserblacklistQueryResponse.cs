using System.Collections.Generic;
using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Response
{
	/// <summary>
	///     AlipayCommerceTransportOfflinepayUserblacklistQueryResponse.
	/// </summary>
	public class AlipayCommerceTransportOfflinepayUserblacklistQueryResponse : AopResponse
	{
		/// <summary>
		///     黑名单用户ID
		/// </summary>
		[JsonProperty("black_list")]
		
		public List<string> BlackList { get; set; }
	}
}