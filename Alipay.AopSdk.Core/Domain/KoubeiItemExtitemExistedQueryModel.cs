using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Domain
{
	/// <summary>
	///     KoubeiItemExtitemExistedQueryModel Data Structure.
	/// </summary>
	[Serializable]
	public class KoubeiItemExtitemExistedQueryModel : AopObject
	{
		/// <summary>
		///     商品编码列表, 商品编码数量不超过100条。
		/// </summary>
		[JsonProperty("code_list")]
		
		public List<string> CodeList { get; set; }
	}
}