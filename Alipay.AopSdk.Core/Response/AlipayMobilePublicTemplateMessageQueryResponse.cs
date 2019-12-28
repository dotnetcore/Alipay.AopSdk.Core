using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Response
{
	/// <summary>
	///     AlipayMobilePublicTemplateMessageQueryResponse.
	/// </summary>
	public class AlipayMobilePublicTemplateMessageQueryResponse : AopResponse
	{
		/// <summary>
		///     结果值
		/// </summary>
		[JsonProperty("result")]
		public string Result { get; set; }
	}
}