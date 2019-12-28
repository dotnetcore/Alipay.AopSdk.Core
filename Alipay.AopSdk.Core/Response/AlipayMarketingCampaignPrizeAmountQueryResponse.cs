using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Response
{
	/// <summary>
	///     AlipayMarketingCampaignPrizeAmountQueryResponse.
	/// </summary>
	public class AlipayMarketingCampaignPrizeAmountQueryResponse : AopResponse
	{
		/// <summary>
		///     奖品剩余数量，数值
		/// </summary>
		[JsonProperty("remain_amount")]
		public string RemainAmount { get; set; }
	}
}