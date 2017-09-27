using System;
using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Domain
{
	/// <summary>
	///     KoubeiMarketingToolPointsQueryModel Data Structure.
	/// </summary>
	[Serializable]
	public class KoubeiMarketingToolPointsQueryModel : AopObject
	{
		/// <summary>
		///     活动积分帐户
		/// </summary>
		[JsonProperty("activity_account")]
		public string ActivityAccount { get; set; }

		/// <summary>
		///     用户ID
		/// </summary>
		[JsonProperty("user_id")]
		public string UserId { get; set; }
	}
}