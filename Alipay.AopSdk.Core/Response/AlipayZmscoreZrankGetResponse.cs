using Newtonsoft.Json;
using Alipay.AopSdk.Core.Domain;

namespace Alipay.AopSdk.Core.Response
{
	/// <summary>
	///     AlipayZmscoreZrankGetResponse.
	/// </summary>
	public class AlipayZmscoreZrankGetResponse : AopResponse
	{
		/// <summary>
		///     芝麻分分段
		/// </summary>
		[JsonProperty("zm_score_zrank")]
		public AlipayZmScoreZrankResult ZmScoreZrank { get; set; }
	}
}