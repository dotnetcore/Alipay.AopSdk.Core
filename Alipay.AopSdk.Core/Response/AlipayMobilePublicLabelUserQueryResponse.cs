using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Response
{
	/// <summary>
	///     AlipayMobilePublicLabelUserQueryResponse.
	/// </summary>
	public class AlipayMobilePublicLabelUserQueryResponse : AopResponse
	{
		/// <summary>
		///     结果码
		/// </summary>
		[JsonProperty("code")]
		public string Code { get; set; }

		/// <summary>
		///     标签编号，英文逗号分隔。
		/// </summary>
		[JsonProperty("label_ids")]
		public string LabelIds { get; set; }

		/// <summary>
		///     结果信息
		/// </summary>
		[JsonProperty("msg")]
		public string Msg { get; set; }
	}
}