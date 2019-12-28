using Newtonsoft.Json;
using Alipay.AopSdk.Core.Domain;

namespace Alipay.AopSdk.Core.Response
{
	/// <summary>
	///     AlipayMarketingCardOpenResponse.
	/// </summary>
	public class AlipayMarketingCardOpenResponse : AopResponse
	{
		/// <summary>
		///     商户卡信息（包括支付宝分配的业务卡号）
		/// </summary>
		[JsonProperty("card_info")]
		public MerchantCard CardInfo { get; set; }
	}
}