using System;
using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Domain
{
	/// <summary>
	///     AlipayEbppInvoiceTitleListGetModel Data Structure.
	/// </summary>
	[Serializable]
	public class AlipayEbppInvoiceTitleListGetModel : AopObject
	{
		/// <summary>
		///     支付宝用户id
		/// </summary>
		[JsonProperty("user_id")]
		public string UserId { get; set; }
	}
}