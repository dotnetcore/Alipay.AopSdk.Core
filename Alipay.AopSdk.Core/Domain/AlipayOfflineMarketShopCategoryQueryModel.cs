using System;
using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Domain
{
	/// <summary>
	///     AlipayOfflineMarketShopCategoryQueryModel Data Structure.
	/// </summary>
	[Serializable]
	public class AlipayOfflineMarketShopCategoryQueryModel : AopObject
	{
		/// <summary>
		///     类目ID，如果为空则查询全部类目。
		/// </summary>
		[JsonProperty("category_id")]
		public string CategoryId { get; set; }

		/// <summary>
		///     表示接口业务的调用方身份,默认不填标识为ISV。
		/// </summary>
		[JsonProperty("op_role")]
		public string OpRole { get; set; }
	}
}