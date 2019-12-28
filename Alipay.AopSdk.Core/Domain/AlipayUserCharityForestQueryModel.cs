using System;
using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Domain
{
	/// <summary>
	///     AlipayUserCharityForestQueryModel Data Structure.
	/// </summary>
	[Serializable]
	public class AlipayUserCharityForestQueryModel : AopObject
	{
		/// <summary>
		///     用户的支付宝账户ID
		/// </summary>
		[JsonProperty("user_id")]
		public string UserId { get; set; }
	}
}