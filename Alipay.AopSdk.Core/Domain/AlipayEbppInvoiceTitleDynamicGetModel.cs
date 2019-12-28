using System;
using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Domain
{
	/// <summary>
	///     AlipayEbppInvoiceTitleDynamicGetModel Data Structure.
	/// </summary>
	[Serializable]
	public class AlipayEbppInvoiceTitleDynamicGetModel : AopObject
	{
		/// <summary>
		///     抬头动态码
		/// </summary>
		[JsonProperty("bar_code")]
		public string BarCode { get; set; }
	}
}