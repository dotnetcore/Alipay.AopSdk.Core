using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Response
{
	/// <summary>
	///     AlipayOpenAppYufanlingsanyaowuYufalingsanyaowuQueryResponse.
	/// </summary>
	public class AlipayOpenAppYufanlingsanyaowuYufalingsanyaowuQueryResponse : AopResponse
	{
		/// <summary>
		///     10
		/// </summary>
		[JsonProperty("userid")]
		public string Userid { get; set; }
	}
}