using System;
using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Domain
{
	/// <summary>
	///     KoubeiMarketingDataAlisisReportBatchqueryModel Data Structure.
	/// </summary>
	[Serializable]
	public class KoubeiMarketingDataAlisisReportBatchqueryModel : AopObject
	{
		/// <summary>
		///     当前页码
		/// </summary>
		[JsonProperty("page")]
		public string Page { get; set; }

		/// <summary>
		///     每页最大条数，最大为30
		/// </summary>
		[JsonProperty("size")]
		public string Size { get; set; }
	}
}