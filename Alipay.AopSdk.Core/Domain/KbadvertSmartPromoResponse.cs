using System;
using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Domain
{
	/// <summary>
	///     KbadvertSmartPromoResponse Data Structure.
	/// </summary>
	[Serializable]
	public class KbadvertSmartPromoResponse : AopObject
	{
		/// <summary>
		///     智能营销分组ID
		/// </summary>
		[JsonProperty("group_id")]
		public string GroupId { get; set; }

		/// <summary>
		///     智能营销方案ID
		/// </summary>
		[JsonProperty("plan_id")]
		public string PlanId { get; set; }
	}
}