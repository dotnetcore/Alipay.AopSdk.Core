using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Response
{
	/// <summary>
	///     KoubeiQualityTestCloudacptCheckresultSubmitResponse.
	/// </summary>
	public class KoubeiQualityTestCloudacptCheckresultSubmitResponse : AopResponse
	{
		/// <summary>
		///     活动id
		/// </summary>
		[JsonProperty("activity_id")]
		public string ActivityId { get; set; }

		/// <summary>
		///     批次
		/// </summary>
		[JsonProperty("batch_id")]
		public string BatchId { get; set; }
	}
}