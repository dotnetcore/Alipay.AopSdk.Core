using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Response
{
	/// <summary>
	///     AlipayMarketingCardConsumeSyncResponse.
	/// </summary>
	public class AlipayMarketingCardConsumeSyncResponse : AopResponse
	{
		/// <summary>
		///     外部卡号
		/// </summary>
		[JsonProperty("external_card_no")]
		public string ExternalCardNo { get; set; }
	}
}