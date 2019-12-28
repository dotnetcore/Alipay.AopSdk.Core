using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Domain
{
	/// <summary>
	///     InvestigCategoryResult Data Structure.
	/// </summary>
	[Serializable]
	public class InvestigCategoryResult : AopObject
	{
		/// <summary>
		///     数据项Category
		/// </summary>
		[JsonProperty("category")]
		public string Category { get; set; }

		/// <summary>
		///     数据项对应的所有采集结果
		/// </summary>
		[JsonProperty("category_result")]
		
		public List<InvestigCategoryData> CategoryResult { get; set; }
	}
}