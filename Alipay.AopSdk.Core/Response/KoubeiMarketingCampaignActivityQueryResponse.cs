using Newtonsoft.Json;
using Alipay.AopSdk.Core.Domain;

namespace Alipay.AopSdk.Core.Response
{
	/// <summary>
	///     KoubeiMarketingCampaignActivityQueryResponse.
	/// </summary>
	public class KoubeiMarketingCampaignActivityQueryResponse : AopResponse
	{
		/// <summary>
		///     活动详情
		/// </summary>
		[JsonProperty("camp_detail")]
		public CampDetail CampDetail { get; set; }
	}
}