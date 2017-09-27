using System;
using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Domain
{
	/// <summary>
	///     AlipayMarketingVoucherTemplateDeleteModel Data Structure.
	/// </summary>
	[Serializable]
	public class AlipayMarketingVoucherTemplateDeleteModel : AopObject
	{
		/// <summary>
		///     券模板ID
		/// </summary>
		[JsonProperty("template_id")]
		public string TemplateId { get; set; }
	}
}