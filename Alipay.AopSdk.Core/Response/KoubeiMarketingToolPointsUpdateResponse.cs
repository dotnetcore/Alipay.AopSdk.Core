using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Response
{
	/// <summary>
	///     KoubeiMarketingToolPointsUpdateResponse.
	/// </summary>
	public class KoubeiMarketingToolPointsUpdateResponse : AopResponse
	{
		/// <summary>
		///     集点变更流水号
		/// </summary>
		[JsonProperty("point_log_no")]
		public string PointLogNo { get; set; }
	}
}