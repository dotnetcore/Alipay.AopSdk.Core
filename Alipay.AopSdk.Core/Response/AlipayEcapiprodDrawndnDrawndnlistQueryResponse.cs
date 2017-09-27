using System.Collections.Generic;
using Newtonsoft.Json;
using Alipay.AopSdk.Core.Domain;

namespace Alipay.AopSdk.Core.Response
{
	/// <summary>
	///     AlipayEcapiprodDrawndnDrawndnlistQueryResponse.
	/// </summary>
	public class AlipayEcapiprodDrawndnDrawndnlistQueryResponse : AopResponse
	{
		/// <summary>
		///     支用列表
		/// </summary>
		[JsonProperty("drawndn_list")]
		
		public List<DrawndnVo> DrawndnList { get; set; }

		/// <summary>
		///     唯一一次请求标示
		/// </summary>
		[JsonProperty("request_id")]
		public string RequestId { get; set; }
	}
}