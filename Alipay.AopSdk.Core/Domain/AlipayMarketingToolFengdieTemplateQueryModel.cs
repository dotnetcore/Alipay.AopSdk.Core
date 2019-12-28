using System;
using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Domain
{
	/// <summary>
	///     AlipayMarketingToolFengdieTemplateQueryModel Data Structure.
	/// </summary>
	[Serializable]
	public class AlipayMarketingToolFengdieTemplateQueryModel : AopObject
	{
		/// <summary>
		///     当前页数，默认为1
		/// </summary>
		[JsonProperty("page_number")]
		public long PageNumber { get; set; }

		/// <summary>
		///     每页记录数，不能超过50，默认为10
		/// </summary>
		[JsonProperty("page_size")]
		public long PageSize { get; set; }
	}
}