using System.Collections.Generic;
using Newtonsoft.Json;
using Alipay.AopSdk.Core.Domain;

namespace Alipay.AopSdk.Core.Response
{
	/// <summary>
	///     AlipayEbppInvoiceTitleListGetResponse.
	/// </summary>
	public class AlipayEbppInvoiceTitleListGetResponse : AopResponse
	{
		/// <summary>
		///     抬头列表
		/// </summary>
		[JsonProperty("title_list")]
		
		public List<InvoiceTitleModel> TitleList { get; set; }
	}
}