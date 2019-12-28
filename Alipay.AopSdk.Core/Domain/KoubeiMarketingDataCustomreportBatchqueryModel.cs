using System;
using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Domain
{
	/// <summary>
	///     KoubeiMarketingDataCustomreportBatchqueryModel Data Structure.
	/// </summary>
	[Serializable]
	public class KoubeiMarketingDataCustomreportBatchqueryModel : AopObject
	{
		/// <summary>
		///     当前页号，默认为1
		/// </summary>
		[JsonProperty("page_no")]
		public string PageNo { get; set; }

		/// <summary>
		///     每页条目数，默认为20,最大为30
		/// </summary>
		[JsonProperty("page_size")]
		public string PageSize { get; set; }
	}
}