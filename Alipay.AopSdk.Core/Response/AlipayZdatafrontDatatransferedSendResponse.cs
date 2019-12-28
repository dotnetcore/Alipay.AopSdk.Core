using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Response
{
	/// <summary>
	///     AlipayZdatafrontDatatransferedSendResponse.
	/// </summary>
	public class AlipayZdatafrontDatatransferedSendResponse : AopResponse
	{
		/// <summary>
		///     表示数据传输是否成功
		/// </summary>
		[JsonProperty("success")]
		public string Success { get; set; }
	}
}