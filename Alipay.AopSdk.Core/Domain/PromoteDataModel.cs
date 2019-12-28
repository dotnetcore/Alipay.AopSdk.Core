using System;
using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Domain
{
	/// <summary>
	///     PromoteDataModel Data Structure.
	/// </summary>
	[Serializable]
	public class PromoteDataModel : AopObject
	{
		/// <summary>
		///     核销数
		/// </summary>
		[JsonProperty("checked_voucher_num")]
		public long CheckedVoucherNum { get; set; }

		/// <summary>
		///     领券数
		/// </summary>
		[JsonProperty("claim_voucher_num")]
		public long ClaimVoucherNum { get; set; }

		/// <summary>
		///     分佣金额
		/// </summary>
		[JsonProperty("commission_amount")]
		public string CommissionAmount { get; set; }
	}
}