using System.Collections.Generic;
using Newtonsoft.Json;
using Alipay.AopSdk.Core.Domain;

namespace Alipay.AopSdk.Core.Response
{
	/// <summary>
	///     AlipayAccountExrateAllclientrateQueryResponse.
	/// </summary>
	public class AlipayAccountExrateAllclientrateQueryResponse : AopResponse
	{
		/// <summary>
		///     汇率信息列表
		/// </summary>
		[JsonProperty("client_rate_list")]
		
		public List<ExClientRateVO> ClientRateList { get; set; }
	}
}