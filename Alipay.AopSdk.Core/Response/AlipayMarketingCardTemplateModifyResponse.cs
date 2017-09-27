using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Response
{
	/// <summary>
	///     AlipayMarketingCardTemplateModifyResponse.
	/// </summary>
	public class AlipayMarketingCardTemplateModifyResponse : AopResponse
	{
		/// <summary>
		///     模板ID
		/// </summary>
		[JsonProperty("template_id")]
		public string TemplateId { get; set; }
	}
}