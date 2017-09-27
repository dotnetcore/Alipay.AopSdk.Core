using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Response
{
	/// <summary>
	///     AlipayOpenPublicGroupCrowdQueryResponse.
	/// </summary>
	public class AlipayOpenPublicGroupCrowdQueryResponse : AopResponse
	{
		/// <summary>
		///     分组圈出的人群数量
		/// </summary>
		[JsonProperty("count")]
		public string Count { get; set; }
	}
}