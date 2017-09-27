using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Domain
{
	/// <summary>
	///     TemplateBenefitInfoDTO Data Structure.
	/// </summary>
	[Serializable]
	public class TemplateBenefitInfoDTO : AopObject
	{
		/// <summary>
		///     权益描述信息
		/// </summary>
		[JsonProperty("benefit_desc")]
		
		public List<string> BenefitDesc { get; set; }

		/// <summary>
		///     权益结束时间
		/// </summary>
		[JsonProperty("end_date")]
		public string EndDate { get; set; }

		/// <summary>
		///     开始时间
		/// </summary>
		[JsonProperty("start_date")]
		public string StartDate { get; set; }

		/// <summary>
		///     权益描述
		/// </summary>
		[JsonProperty("title")]
		public string Title { get; set; }
	}
}