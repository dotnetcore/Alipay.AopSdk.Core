using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Domain
{
	/// <summary>
	///     QueryGroup Data Structure.
	/// </summary>
	[Serializable]
	public class QueryGroup : AopObject
	{
		/// <summary>
		///     分组id
		/// </summary>
		[JsonProperty("id")]
		public string Id { get; set; }

		/// <summary>
		///     分组中的圈人规则
		/// </summary>
		[JsonProperty("label_rule")]
		
		public List<QueryComplexLabelRule> LabelRule { get; set; }

		/// <summary>
		///     用户分组名称
		/// </summary>
		[JsonProperty("name")]
		public string Name { get; set; }
	}
}