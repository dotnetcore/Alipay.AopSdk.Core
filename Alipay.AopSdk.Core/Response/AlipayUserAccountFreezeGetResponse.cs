using System.Collections.Generic;
using Newtonsoft.Json;
using Alipay.AopSdk.Core.Domain;

namespace Alipay.AopSdk.Core.Response
{
	/// <summary>
	///     AlipayUserAccountFreezeGetResponse.
	/// </summary>
	public class AlipayUserAccountFreezeGetResponse : AopResponse
	{
		/// <summary>
		///     冻结金额列表
		/// </summary>
		[JsonProperty("freeze_items")]
		
		public List<AccountFreeze> FreezeItems { get; set; }

		/// <summary>
		///     冻结总条数
		/// </summary>
		[JsonProperty("total_results")]
		public string TotalResults { get; set; }
	}
}