using Newtonsoft.Json;
using Alipay.AopSdk.Core.Domain;

namespace Alipay.AopSdk.Core.Response
{
	/// <summary>
	///     AlipayMarketingCardQueryResponse.
	/// </summary>
	public class AlipayMarketingCardQueryResponse : AopResponse
	{
		/// <summary>
		///     商户卡信息
		/// </summary>
		[JsonProperty("card_info")]
		public MerchantCard CardInfo { get; set; }

		/// <summary>
		///     商户会员卡页面跳转到支付宝卡券详情页面的schema地址
		/// </summary>
		[JsonProperty("schema_url")]
		public string SchemaUrl { get; set; }
	}
}