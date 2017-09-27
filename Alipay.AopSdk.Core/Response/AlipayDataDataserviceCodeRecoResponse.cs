using Newtonsoft.Json;
using Alipay.AopSdk.Core.Domain;

namespace Alipay.AopSdk.Core.Response
{
	/// <summary>
	///     AlipayDataDataserviceCodeRecoResponse.
	/// </summary>
	public class AlipayDataDataserviceCodeRecoResponse : AopResponse
	{
		/// <summary>
		///     识别结果
		/// </summary>
		[JsonProperty("result")]
		public AlipayCodeRecoResult Result { get; set; }
	}
}