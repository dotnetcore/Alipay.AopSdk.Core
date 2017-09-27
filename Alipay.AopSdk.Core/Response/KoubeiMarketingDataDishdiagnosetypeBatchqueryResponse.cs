using System.Collections.Generic;
using Newtonsoft.Json;
using Alipay.AopSdk.Core.Domain;

namespace Alipay.AopSdk.Core.Response
{
	/// <summary>
	///     KoubeiMarketingDataDishdiagnosetypeBatchqueryResponse.
	/// </summary>
	public class KoubeiMarketingDataDishdiagnosetypeBatchqueryResponse : AopResponse
	{
		/// <summary>
		///     菜品类型list
		/// </summary>
		[JsonProperty("item_diagnose_type_list")]
		
		public List<ItemDiagnoseType> ItemDiagnoseTypeList { get; set; }
	}
}