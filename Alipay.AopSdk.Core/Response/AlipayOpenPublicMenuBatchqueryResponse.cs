using System.Collections.Generic;
using Newtonsoft.Json;
using Alipay.AopSdk.Core.Domain;

namespace Alipay.AopSdk.Core.Response
{
	/// <summary>
	///     AlipayOpenPublicMenuBatchqueryResponse.
	/// </summary>
	public class AlipayOpenPublicMenuBatchqueryResponse : AopResponse
	{
		/// <summary>
		///     菜单数量，包括默认菜单和个性化菜单
		/// </summary>
		[JsonProperty("count")]
		public string Count { get; set; }

		/// <summary>
		///     菜单列表
		/// </summary>
		[JsonProperty("menus")]
		
		public List<QueryMenu> Menus { get; set; }
	}
}