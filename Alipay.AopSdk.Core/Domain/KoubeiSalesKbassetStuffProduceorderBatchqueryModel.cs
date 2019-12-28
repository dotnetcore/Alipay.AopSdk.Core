using System;
using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Domain
{
	/// <summary>
	///     KoubeiSalesKbassetStuffProduceorderBatchqueryModel Data Structure.
	/// </summary>
	[Serializable]
	public class KoubeiSalesKbassetStuffProduceorderBatchqueryModel : AopObject
	{
		/// <summary>
		///     每页容量：最小1，最大100
		/// </summary>
		[JsonProperty("page_size")]
		public string PageSize { get; set; }
	}
}