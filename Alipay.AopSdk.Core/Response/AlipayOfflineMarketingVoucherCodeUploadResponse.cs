using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Response
{
	/// <summary>
	///     AlipayOfflineMarketingVoucherCodeUploadResponse.
	/// </summary>
	public class AlipayOfflineMarketingVoucherCodeUploadResponse : AopResponse
	{
		/// <summary>
		///     码库id
		/// </summary>
		[JsonProperty("code_inventory_id")]
		public string CodeInventoryId { get; set; }
	}
}