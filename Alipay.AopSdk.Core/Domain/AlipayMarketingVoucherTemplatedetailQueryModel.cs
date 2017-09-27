using System;
using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Domain
{
	/// <summary>
	///     AlipayMarketingVoucherTemplatedetailQueryModel Data Structure.
	/// </summary>
	[Serializable]
	public class AlipayMarketingVoucherTemplatedetailQueryModel : AopObject
	{
		/// <summary>
		///     券模板ID
		/// </summary>
		[JsonProperty("template_id")]
		public string TemplateId { get; set; }
	}
}