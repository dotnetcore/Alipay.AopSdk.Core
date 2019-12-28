using System;
using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Domain
{
	/// <summary>
	///     AlipayUserPrincipalInfo Data Structure.
	/// </summary>
	[Serializable]
	public class AlipayUserPrincipalInfo : AopObject
	{
		/// <summary>
		///     用户电子邮箱
		/// </summary>
		[JsonProperty("email")]
		public string Email { get; set; }

		/// <summary>
		///     用户的手机号
		/// </summary>
		[JsonProperty("mobile")]
		public string Mobile { get; set; }

		/// <summary>
		///     支付宝userId
		/// </summary>
		[JsonProperty("user_id")]
		public string UserId { get; set; }
	}
}