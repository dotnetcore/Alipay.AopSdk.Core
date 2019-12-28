using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Response
{
	/// <summary>
	///     AlipayMarketingCardActivateurlApplyResponse.
	/// </summary>
	public class AlipayMarketingCardActivateurlApplyResponse : AopResponse
	{
		/// <summary>
		///     会员卡领卡链接。商户获取此链接后可投放到服务窗消息、店铺二维码等。
		/// </summary>
		[JsonProperty("apply_card_url")]
		public string ApplyCardUrl { get; set; }
	}
}