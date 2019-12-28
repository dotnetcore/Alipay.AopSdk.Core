using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Response
{
	/// <summary>
	///     AlipayMdataTagGetResponse.
	/// </summary>
	public class AlipayMdataTagGetResponse : AopResponse
	{
		/// <summary>
		///     查询到的标签值, JSON字符串
		/// </summary>
		[JsonProperty("tag_values")]
		public string TagValues { get; set; }
	}
}