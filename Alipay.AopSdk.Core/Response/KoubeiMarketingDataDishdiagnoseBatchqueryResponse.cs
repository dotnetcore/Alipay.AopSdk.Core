using System.Collections.Generic;
using Newtonsoft.Json;
using Alipay.AopSdk.Core.Domain;

namespace Alipay.AopSdk.Core.Response
{
	/// <summary>
	///     KoubeiMarketingDataDishdiagnoseBatchqueryResponse.
	/// </summary>
	public class KoubeiMarketingDataDishdiagnoseBatchqueryResponse : AopResponse
	{
		/// <summary>
		///     查询返回的详情数据
		/// </summary>
		[JsonProperty("item_diagnose_list")]
		
		public List<ItemDiagnoseDetail> ItemDiagnoseList { get; set; }

		/// <summary>
		///     记录的总条数
		/// </summary>
		[JsonProperty("total")]
		public long Total { get; set; }
	}
}