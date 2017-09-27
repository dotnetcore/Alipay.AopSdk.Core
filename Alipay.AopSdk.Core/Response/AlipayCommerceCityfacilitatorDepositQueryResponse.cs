using System.Collections.Generic;
using Newtonsoft.Json;
using Alipay.AopSdk.Core.Domain;

namespace Alipay.AopSdk.Core.Response
{
	/// <summary>
	///     AlipayCommerceCityfacilitatorDepositQueryResponse.
	/// </summary>
	public class AlipayCommerceCityfacilitatorDepositQueryResponse : AopResponse
	{
		/// <summary>
		///     待圈存明细
		/// </summary>
		[JsonProperty("recharge_bills")]
		
		public List<RechargeBill> RechargeBills { get; set; }
	}
}