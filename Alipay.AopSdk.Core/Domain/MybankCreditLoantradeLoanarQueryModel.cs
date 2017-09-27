using System;
using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Domain
{
	/// <summary>
	///     MybankCreditLoantradeLoanarQueryModel Data Structure.
	/// </summary>
	[Serializable]
	public class MybankCreditLoantradeLoanarQueryModel : AopObject
	{
		/// <summary>
		///     客户的角色编号
		/// </summary>
		[JsonProperty("iproleid")]
		public string Iproleid { get; set; }

		/// <summary>
		///     合约编号
		/// </summary>
		[JsonProperty("loanarno")]
		public string Loanarno { get; set; }
	}
}