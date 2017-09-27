using System;
using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Domain
{
	/// <summary>
	///     AlipayMarketingCampaignRuleTagQueryModel Data Structure.
	/// </summary>
	[Serializable]
	public class AlipayMarketingCampaignRuleTagQueryModel : AopObject
	{
		/// <summary>
		///     签约商户下属机构唯一编号
		/// </summary>
		[JsonProperty("mpid")]
		public string Mpid { get; set; }
	}
}