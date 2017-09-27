using Newtonsoft.Json;
using Alipay.AopSdk.Core.Domain;

namespace Alipay.AopSdk.Core.Response
{
	/// <summary>
	///     AlipayInsSceneCouponReceiveResponse.
	/// </summary>
	public class AlipayInsSceneCouponReceiveResponse : AopResponse
	{
		/// <summary>
		///     保单凭证号;商户生成的外部投保业务号不传时则必传
		/// </summary>
		[JsonProperty("policy_no")]
		public string PolicyNo { get; set; }

		/// <summary>
		///     保险产品
		/// </summary>
		[JsonProperty("product")]
		public InsProduct Product { get; set; }
	}
}