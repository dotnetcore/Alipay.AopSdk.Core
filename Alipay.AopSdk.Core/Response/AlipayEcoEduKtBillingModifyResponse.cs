using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Response
{
	/// <summary>
	///     AlipayEcoEduKtBillingModifyResponse.
	/// </summary>
	public class AlipayEcoEduKtBillingModifyResponse : AopResponse
	{
		/// <summary>
		///     如果成功，返回Y
		/// </summary>
		[JsonProperty("status")]
		public string Status { get; set; }
	}
}