using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Response
{
	/// <summary>
	///     AlipaySecurityProdAlipaySecurityProdTestResponse.
	/// </summary>
	public class AlipaySecurityProdAlipaySecurityProdTestResponse : AopResponse
	{
		/// <summary>
		///     ddd
		/// </summary>
		[JsonProperty("admin")]
		public string Admin { get; set; }
	}
}