using System.Collections.Generic;
using Newtonsoft.Json;
using Alipay.AopSdk.Core.Domain;

namespace Alipay.AopSdk.Core.Response
{
	/// <summary>
	///     AlipayEcapiprodDrawndnRepaymentrecordQueryResponse.
	/// </summary>
	public class AlipayEcapiprodDrawndnRepaymentrecordQueryResponse : AopResponse
	{
		/// <summary>
		///     还款流水
		/// </summary>
		[JsonProperty("repayment_records")]
		
		public List<RepaymentRecords> RepaymentRecords { get; set; }

		/// <summary>
		///     唯一标识这次请求
		/// </summary>
		[JsonProperty("request_id")]
		public string RequestId { get; set; }
	}
}