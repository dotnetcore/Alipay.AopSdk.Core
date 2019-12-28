using System.Collections.Generic;
using Newtonsoft.Json;
using Alipay.AopSdk.Core.Domain;

namespace Alipay.AopSdk.Core.Response
{
	/// <summary>
	///     AlipayUserAccountSearchResponse.
	/// </summary>
	public class AlipayUserAccountSearchResponse : AopResponse
	{
		/// <summary>
		///     支付宝用户账务明细信息
		/// </summary>
		[JsonProperty("account_records")]
		
		public List<AccountRecord> AccountRecords { get; set; }

		/// <summary>
		///     总页面数
		/// </summary>
		[JsonProperty("total_pages")]
		public long TotalPages { get; set; }

		/// <summary>
		///     总记录数
		/// </summary>
		[JsonProperty("total_results")]
		public long TotalResults { get; set; }
	}
}