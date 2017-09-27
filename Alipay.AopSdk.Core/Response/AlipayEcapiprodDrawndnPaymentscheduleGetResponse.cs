using System.Collections.Generic;
using Newtonsoft.Json;
using Alipay.AopSdk.Core.Domain;

namespace Alipay.AopSdk.Core.Response
{
	/// <summary>
	///     AlipayEcapiprodDrawndnPaymentscheduleGetResponse.
	/// </summary>
	public class AlipayEcapiprodDrawndnPaymentscheduleGetResponse : AopResponse
	{
		/// <summary>
		///     返回的支用还款计划集合
		/// </summary>
		[JsonProperty("payment_schedules")]
		
		public List<PaymentSchedule> PaymentSchedules { get; set; }

		/// <summary>
		///     唯一标识这次请求
		/// </summary>
		[JsonProperty("request_id")]
		public string RequestId { get; set; }
	}
}