using System;
using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Domain
{
	/// <summary>
	///     AlipayMarketingCardTemplateQueryModel Data Structure.
	/// </summary>
	[Serializable]
	public class AlipayMarketingCardTemplateQueryModel : AopObject
	{
		/// <summary>
		///     支付宝卡模板ID（模板创建接口返回的支付宝端模板ID）
		/// </summary>
		[JsonProperty("template_id")]
		public string TemplateId { get; set; }
	}
}