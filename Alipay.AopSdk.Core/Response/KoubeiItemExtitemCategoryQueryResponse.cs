using System.Collections.Generic;
using Newtonsoft.Json;
using Alipay.AopSdk.Core.Domain;

namespace Alipay.AopSdk.Core.Response
{
	/// <summary>
	///     KoubeiItemExtitemCategoryQueryResponse.
	/// </summary>
	public class KoubeiItemExtitemCategoryQueryResponse : AopResponse
	{
		/// <summary>
		///     品类信息列表
		/// </summary>
		[JsonProperty("category_list")]
		
		public List<ExtCategory> CategoryList { get; set; }
	}
}