using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Response
{
	/// <summary>
	///     AlipayMobilePublicLabelUpdateResponse.
	/// </summary>
	public class AlipayMobilePublicLabelUpdateResponse : AopResponse
	{
		/// <summary>
		///     结果码
		/// </summary>
		[JsonProperty("code")]
		public string Code { get; set; }

		/// <summary>
		///     标签编号
		/// </summary>
		[JsonProperty("id")]
		public long Id { get; set; }

		/// <summary>
		///     结果信息
		/// </summary>
		[JsonProperty("msg")]
		public string Msg { get; set; }
	}
}