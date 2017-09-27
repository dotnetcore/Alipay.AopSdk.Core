using System;
using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Domain
{
	/// <summary>
	///     AlipayEbppInvoiceFileQueryModel Data Structure.
	/// </summary>
	[Serializable]
	public class AlipayEbppInvoiceFileQueryModel : AopObject
	{
		/// <summary>
		///     支付宝端生成的发票id，该字段可从发票详情查询接口获得
		/// </summary>
		[JsonProperty("invoice_id")]
		public string InvoiceId { get; set; }
	}
}