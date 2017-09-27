using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Response
{
	/// <summary>
	///     KoubeiCraftsmanDataProviderCreateResponse.
	/// </summary>
	public class KoubeiCraftsmanDataProviderCreateResponse : AopResponse
	{
		/// <summary>
		///     手艺人id
		/// </summary>
		[JsonProperty("craftsman_id")]
		public string CraftsmanId { get; set; }
	}
}