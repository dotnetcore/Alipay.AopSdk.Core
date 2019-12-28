using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Response
{
	/// <summary>
	///     AlipayMarketingCardTemplateCreateResponse.
	/// </summary>
	public class AlipayMarketingCardTemplateCreateResponse : AopResponse
	{
		/// <summary>
		///     支付宝卡模板ID
		/// </summary>
		[JsonProperty("template_id")]
		public string TemplateId { get; set; }
	}
}