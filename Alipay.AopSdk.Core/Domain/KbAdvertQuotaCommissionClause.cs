using System;
using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Domain
{
	/// <summary>
	///     KbAdvertQuotaCommissionClause Data Structure.
	/// </summary>
	[Serializable]
	public class KbAdvertQuotaCommissionClause : AopObject
	{
		/// <summary>
		///     固定金额
		/// </summary>
		[JsonProperty("quota_amount")]
		public string QuotaAmount { get; set; }
	}
}