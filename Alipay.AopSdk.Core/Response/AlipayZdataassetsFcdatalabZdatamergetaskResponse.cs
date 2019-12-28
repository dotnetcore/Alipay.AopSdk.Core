using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Response
{
	/// <summary>
	///     AlipayZdataassetsFcdatalabZdatamergetaskResponse.
	/// </summary>
	public class AlipayZdataassetsFcdatalabZdatamergetaskResponse : AopResponse
	{
		/// <summary>
		///     返回结果
		/// </summary>
		[JsonProperty("result")]
		public string Result { get; set; }
	}
}