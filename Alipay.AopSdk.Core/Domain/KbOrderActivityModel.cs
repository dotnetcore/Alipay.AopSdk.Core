using System;
using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Domain
{
	/// <summary>
	///     KbOrderActivityModel Data Structure.
	/// </summary>
	[Serializable]
	public class KbOrderActivityModel : AopObject
	{
		/// <summary>
		///     活动ID
		/// </summary>
		[JsonProperty("activity_id")]
		public string ActivityId { get; set; }

		/// <summary>
		///     商品ID
		/// </summary>
		[JsonProperty("item_id")]
		public string ItemId { get; set; }
	}
}