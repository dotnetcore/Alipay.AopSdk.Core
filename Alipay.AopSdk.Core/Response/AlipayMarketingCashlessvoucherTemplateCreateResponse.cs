using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Response
{
	/// <summary>
	///     AlipayMarketingCashlessvoucherTemplateCreateResponse.
	/// </summary>
	public class AlipayMarketingCashlessvoucherTemplateCreateResponse : AopResponse
	{
		/// <summary>
		///     模板ID
		/// </summary>
		[JsonProperty("template_id")]
		public string TemplateId { get; set; }
	}
}