using System.Collections.Generic;
using Newtonsoft.Json;
using Alipay.AopSdk.Core.Domain;

namespace Alipay.AopSdk.Core.Response
{
	/// <summary>
	///     KoubeiItemExtitemBrandQueryResponse.
	/// </summary>
	public class KoubeiItemExtitemBrandQueryResponse : AopResponse
	{
		/// <summary>
		///     品牌列表信息
		/// </summary>
		[JsonProperty("brand_list")]
		
		public List<ExtBrand> BrandList { get; set; }
	}
}