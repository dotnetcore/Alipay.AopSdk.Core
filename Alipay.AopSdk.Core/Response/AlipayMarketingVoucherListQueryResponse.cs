using System.Collections.Generic;
using Newtonsoft.Json;
using Alipay.AopSdk.Core.Domain;

namespace Alipay.AopSdk.Core.Response
{
	/// <summary>
	///     AlipayMarketingVoucherListQueryResponse.
	/// </summary>
	public class AlipayMarketingVoucherListQueryResponse : AopResponse
	{
		/// <summary>
		///     券列表，一定不为null，但是size可以为0
		/// </summary>
		[JsonProperty("vouchers")]
		
		public List<VoucherLiteInfo> Vouchers { get; set; }
	}
}