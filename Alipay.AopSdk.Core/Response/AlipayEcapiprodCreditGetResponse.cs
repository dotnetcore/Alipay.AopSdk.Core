using Newtonsoft.Json;
using Alipay.AopSdk.Core.Domain;

namespace Alipay.AopSdk.Core.Response
{
	/// <summary>
	///     AlipayEcapiprodCreditGetResponse.
	/// </summary>
	public class AlipayEcapiprodCreditGetResponse : AopResponse
	{
		/// <summary>
		///     授信结果
		/// </summary>
		[JsonProperty("credit_result")]
		public CreditResult CreditResult { get; set; }

		/// <summary>
		///     为了保持幂等性，返回唯一请求号
		/// </summary>
		[JsonProperty("request_id")]
		public string RequestId { get; set; }
	}
}