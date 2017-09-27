using System;
using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Domain
{
	/// <summary>
	///     AlipayMarketingCampaignRuleCrowdDeleteModel Data Structure.
	/// </summary>
	[Serializable]
	public class AlipayMarketingCampaignRuleCrowdDeleteModel : AopObject
	{
		/// <summary>
		///     签约商户下属子机构唯一编号
		/// </summary>
		[JsonProperty("mpid")]
		public string Mpid { get; set; }

		/// <summary>
		///     对没有在使用的规则进行删除
		/// </summary>
		[JsonProperty("ruleid")]
		public string Ruleid { get; set; }
	}
}