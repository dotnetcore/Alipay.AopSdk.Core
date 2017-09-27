using System;
using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Domain
{
	/// <summary>
	///     StaffInfo Data Structure.
	/// </summary>
	[Serializable]
	public class StaffInfo : AopObject
	{
		/// <summary>
		///     支付宝登录账号
		/// </summary>
		[JsonProperty("logon_id")]
		public string LogonId { get; set; }

		/// <summary>
		///     用户uid
		/// </summary>
		[JsonProperty("user_id")]
		public string UserId { get; set; }
	}
}