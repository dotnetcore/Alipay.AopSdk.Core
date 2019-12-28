using System;
using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Domain
{
	/// <summary>
	///     AlipayUserFinanceinfoShareModel Data Structure.
	/// </summary>
	[Serializable]
	public class AlipayUserFinanceinfoShareModel : AopObject
	{
		/// <summary>
		///     支付宝会员的userId
		/// </summary>
		[JsonProperty("user_id")]
		public string UserId { get; set; }
	}
}