using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Response
{
	/// <summary>
	///     AlipayPcreditHuabeiPromoQueryResponse.
	/// </summary>
	public class AlipayPcreditHuabeiPromoQueryResponse : AopResponse
	{
		/// <summary>
		///     花呗颜值分
		/// </summary>
		[JsonProperty("facescore")]
		public string Facescore { get; set; }
	}
}