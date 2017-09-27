using System.Collections.Generic;
using Newtonsoft.Json;
using Alipay.AopSdk.Core.Domain;

namespace Alipay.AopSdk.Core.Response
{
	/// <summary>
	///     AlipayEcoCplifeBillModifyResponse.
	/// </summary>
	public class AlipayEcoCplifeBillModifyResponse : AopResponse
	{
		/// <summary>
		///     不允许修改（支付中或者支付完成）的账单明细条目列表
		/// </summary>
		[JsonProperty("alive_bill_entry_list")]
		
		public List<CPAliveBillEntrySet> AliveBillEntryList { get; set; }
	}
}