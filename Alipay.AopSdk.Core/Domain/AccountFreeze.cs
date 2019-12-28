using System;
using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Domain
{
	/// <summary>
	///     AccountFreeze Data Structure.
	/// </summary>
	[Serializable]
	public class AccountFreeze : AopObject
	{
		/// <summary>
		///     冻结金额
		/// </summary>
		[JsonProperty("freeze_amount")]
		public string FreezeAmount { get; set; }

		/// <summary>
		///     冻结类型名称
		/// </summary>
		[JsonProperty("freeze_name")]
		public string FreezeName { get; set; }

		/// <summary>
		///     冻结类型值
		/// </summary>
		[JsonProperty("freeze_type")]
		public string FreezeType { get; set; }
	}
}