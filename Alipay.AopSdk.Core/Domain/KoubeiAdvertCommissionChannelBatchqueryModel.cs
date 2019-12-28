using System;
using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Domain
{
	/// <summary>
	///     KoubeiAdvertCommissionChannelBatchqueryModel Data Structure.
	/// </summary>
	[Serializable]
	public class KoubeiAdvertCommissionChannelBatchqueryModel : AopObject
	{
		/// <summary>
		///     页码
		/// </summary>
		[JsonProperty("page_index")]
		public string PageIndex { get; set; }

		/// <summary>
		///     每页数量
		/// </summary>
		[JsonProperty("page_size")]
		public string PageSize { get; set; }
	}
}