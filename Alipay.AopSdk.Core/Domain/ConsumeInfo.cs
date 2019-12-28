using System;
using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Domain
{
	/// <summary>
	///     ConsumeInfo Data Structure.
	/// </summary>
	[Serializable]
	public class ConsumeInfo : AopObject
	{
		/// <summary>
		///     领取时间
		/// </summary>
		[JsonProperty("taken_time")]
		public string TakenTime { get; set; }

		/// <summary>
		///     用户名
		/// </summary>
		[JsonProperty("user_name")]
		public string UserName { get; set; }

		/// <summary>
		///     面额（单位分）
		/// </summary>
		[JsonProperty("voucher_amt")]
		public string VoucherAmt { get; set; }
	}
}