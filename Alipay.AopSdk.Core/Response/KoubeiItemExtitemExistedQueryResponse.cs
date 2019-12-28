using System.Collections.Generic;
using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Response
{
	/// <summary>
	///     KoubeiItemExtitemExistedQueryResponse.
	/// </summary>
	public class KoubeiItemExtitemExistedQueryResponse : AopResponse
	{
		/// <summary>
		///     商品库中存在的商品编码
		/// </summary>
		[JsonProperty("existed_list")]
		
		public List<string> ExistedList { get; set; }
	}
}