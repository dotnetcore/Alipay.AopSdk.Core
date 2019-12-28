using System.Collections.Generic;
using Newtonsoft.Json;
using Alipay.AopSdk.Core.Domain;

namespace Alipay.AopSdk.Core.Response
{
	/// <summary>
	///     KoubeiItemCategoryChildrenBatchqueryResponse.
	/// </summary>
	public class KoubeiItemCategoryChildrenBatchqueryResponse : AopResponse
	{
		/// <summary>
		///     口碑标准后台类目信息列表
		/// </summary>
		[JsonProperty("category_list")]
		
		public List<StandardCategoryInfo> CategoryList { get; set; }
	}
}