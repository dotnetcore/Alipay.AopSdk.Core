using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Response
{
	/// <summary>
	///     AlipayMobilePublicAccountResetResponse.
	/// </summary>
	public class AlipayMobilePublicAccountResetResponse : AopResponse
	{
		/// <summary>
		///     这是新账户绑定成功后产生的协议号
		/// </summary>
		[JsonProperty("agreement_id")]
		public string AgreementId { get; set; }

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