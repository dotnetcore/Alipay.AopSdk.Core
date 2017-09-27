using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Response
{
	/// <summary>
	///     AlipayMarketingCampaignDiscountOperateResponse.
	/// </summary>
	public class AlipayMarketingCampaignDiscountOperateResponse : AopResponse
	{
		/// <summary>
		///     123
		/// </summary>
		[JsonProperty("camp_id")]
		public string CampId { get; set; }
	}
}