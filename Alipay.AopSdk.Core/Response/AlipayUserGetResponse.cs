using Newtonsoft.Json;
using Alipay.AopSdk.Core.Domain;

namespace Alipay.AopSdk.Core.Response
{
	/// <summary>
	///     AlipayUserGetResponse.
	/// </summary>
	public class AlipayUserGetResponse : AopResponse
	{
		/// <summary>
		///     支付宝用户信息
		/// </summary>
		[JsonProperty("alipay_user_detail")]
		public AlipayUserDetail AlipayUserDetail { get; set; }
	}
}