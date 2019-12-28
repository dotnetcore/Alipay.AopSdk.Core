using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Response
{
	/// <summary>
	///     KoubeiMarketingDataActivityBillDownloadResponse.
	/// </summary>
	public class KoubeiMarketingDataActivityBillDownloadResponse : AopResponse
	{
		/// <summary>
		///     账单下载地址
		/// </summary>
		[JsonProperty("url")]
		public string Url { get; set; }
	}
}