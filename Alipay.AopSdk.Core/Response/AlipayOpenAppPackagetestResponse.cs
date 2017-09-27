using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Response
{
	/// <summary>
	///     AlipayOpenAppPackagetestResponse.
	/// </summary>
	public class AlipayOpenAppPackagetestResponse : AopResponse
	{
		/// <summary>
		///     testtest
		/// </summary>
		[JsonProperty("testtesttesttest")]
		public string Testtesttesttest { get; set; }
	}
}