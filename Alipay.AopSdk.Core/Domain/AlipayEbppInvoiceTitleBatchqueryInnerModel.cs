using System;
using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Domain
{
	/// <summary>
	///     AlipayEbppInvoiceTitleBatchqueryInnerModel Data Structure.
	/// </summary>
	[Serializable]
	public class AlipayEbppInvoiceTitleBatchqueryInnerModel : AopObject
	{
		/// <summary>
		///     抬头所属支付宝用户id
		/// </summary>
		[JsonProperty("user_id")]
		public string UserId { get; set; }
	}
}