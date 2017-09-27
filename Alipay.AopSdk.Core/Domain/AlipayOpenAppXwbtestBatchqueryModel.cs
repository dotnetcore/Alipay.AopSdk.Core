using System;
using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Domain
{
	/// <summary>
	///     AlipayOpenAppXwbtestBatchqueryModel Data Structure.
	/// </summary>
	[Serializable]
	public class AlipayOpenAppXwbtestBatchqueryModel : AopObject
	{
		/// <summary>
		///     1
		/// </summary>
		[JsonProperty("xwb")]
		public string Xwb { get; set; }
	}
}