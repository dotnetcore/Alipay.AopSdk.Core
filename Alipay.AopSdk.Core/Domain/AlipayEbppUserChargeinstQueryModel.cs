using System;
using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Domain
{
	/// <summary>
	///     AlipayEbppUserChargeinstQueryModel Data Structure.
	/// </summary>
	[Serializable]
	public class AlipayEbppUserChargeinstQueryModel : AopObject
	{
		/// <summary>
		///     用户ID
		/// </summary>
		[JsonProperty("user_id")]
		public string UserId { get; set; }
	}
}