using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Response
{
	/// <summary>
	///     AlipayZdataassetsEasyserviceResponse.
	/// </summary>
	public class AlipayZdataassetsEasyserviceResponse : AopResponse
	{
		/// <summary>
		///     返回结果
		/// </summary>
		[JsonProperty("result")]
		public string Result { get; set; }
	}
}