using Newtonsoft.Json;
using Alipay.AopSdk.Core.Domain;

namespace Alipay.AopSdk.Core.Response
{
	/// <summary>
	///     AlipayTrustUserScoreGetResponse.
	/// </summary>
	public class AlipayTrustUserScoreGetResponse : AopResponse
	{
		/// <summary>
		///     芝麻信用通过模型计算出的该用户的芝麻信用评分
		/// </summary>
		[JsonProperty("ali_trust_score")]
		public AliTrustScore AliTrustScore { get; set; }
	}
}