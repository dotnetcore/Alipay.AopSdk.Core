using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Response
{
	/// <summary>
	///     AlipayMobilePublicLabelUserAddResponse.
	/// </summary>
	public class AlipayMobilePublicLabelUserAddResponse : AopResponse
	{
		/// <summary>
		///     结果码
		/// </summary>
		[JsonProperty("code")]
		public string Code { get; set; }

		/// <summary>
		///     结果信息
		/// </summary>
		[JsonProperty("msg")]
		public string Msg { get; set; }
	}
}