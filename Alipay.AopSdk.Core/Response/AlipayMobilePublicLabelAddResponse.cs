using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Response
{
	/// <summary>
	///     AlipayMobilePublicLabelAddResponse.
	/// </summary>
	public class AlipayMobilePublicLabelAddResponse : AopResponse
	{
		/// <summary>
		///     结果码
		/// </summary>
		[JsonProperty("code")]
		public string Code { get; set; }

		/// <summary>
		///     标签编码
		/// </summary>
		[JsonProperty("id")]
		public long Id { get; set; }

		/// <summary>
		///     结果信息
		/// </summary>
		[JsonProperty("msg")]
		public string Msg { get; set; }

		/// <summary>
		///     标签名称
		/// </summary>
		[JsonProperty("name")]
		public string Name { get; set; }
	}
}