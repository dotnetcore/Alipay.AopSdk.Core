using Newtonsoft.Json;
using Alipay.AopSdk.Core.Domain;

namespace Alipay.AopSdk.Core.Response
{
	/// <summary>
	///     AlipayUserAccountGetResponse.
	/// </summary>
	public class AlipayUserAccountGetResponse : AopResponse
	{
		/// <summary>
		///     支付宝用户账户信息
		/// </summary>
		[JsonProperty("alipay_account")]
		public AlipayAccount AlipayAccount { get; set; }
	}
}