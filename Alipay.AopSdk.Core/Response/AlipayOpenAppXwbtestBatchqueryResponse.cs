using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Response
{
	/// <summary>
	///     AlipayOpenAppXwbtestBatchqueryResponse.
	/// </summary>
	public class AlipayOpenAppXwbtestBatchqueryResponse : AopResponse
	{
		/// <summary>
		///     1
		/// </summary>
		[JsonProperty("xwb")]
		public string Xwb { get; set; }
	}
}