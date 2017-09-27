using System;
using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Domain
{
	/// <summary>
	///     BudgetInfo Data Structure.
	/// </summary>
	[Serializable]
	public class BudgetInfo : AopObject
	{
		/// <summary>
		///     预算数量
		/// </summary>
		[JsonProperty("budget_total")]
		public string BudgetTotal { get; set; }

		/// <summary>
		///     预算类型
		/// </summary>
		[JsonProperty("budget_type")]
		public string BudgetType { get; set; }
	}
}