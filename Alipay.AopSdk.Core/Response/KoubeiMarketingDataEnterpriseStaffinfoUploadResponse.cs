using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Response
{
	/// <summary>
	///     KoubeiMarketingDataEnterpriseStaffinfoUploadResponse.
	/// </summary>
	public class KoubeiMarketingDataEnterpriseStaffinfoUploadResponse : AopResponse
	{
		/// <summary>
		///     人群ID
		/// </summary>
		[JsonProperty("crowd_id")]
		public string CrowdId { get; set; }
	}
}