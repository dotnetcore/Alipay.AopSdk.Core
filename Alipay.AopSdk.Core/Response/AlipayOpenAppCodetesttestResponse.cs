using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Response
{
	/// <summary>
	///     AlipayOpenAppCodetesttestResponse.
	/// </summary>
	public class AlipayOpenAppCodetesttestResponse : AopResponse
	{
		/// <summary>
		///     测试测试测试
		/// </summary>
		[JsonProperty("testtesttest")]
		public string Testtesttest { get; set; }
	}
}