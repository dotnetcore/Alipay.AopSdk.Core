using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Response
{
	/// <summary>
	///     AlipayBossProdArrangementOfflineQueryResponse.
	/// </summary>
	public class AlipayBossProdArrangementOfflineQueryResponse : AopResponse
	{
		/// <summary>
		///     商户的签约状态
		/// </summary>
		[JsonProperty("sign_status")]
		public string SignStatus { get; set; }
	}
}