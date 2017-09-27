using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Domain
{
	/// <summary>
	///     PidShopInfo Data Structure.
	/// </summary>
	[Serializable]
	public class PidShopInfo : AopObject
	{
		/// <summary>
		///     商户pid
		/// </summary>
		[JsonProperty("pid")]
		public string Pid { get; set; }

		/// <summary>
		///     pid下的门店列表
		/// </summary>
		[JsonProperty("shop_ids")]
		
		public List<string> ShopIds { get; set; }
	}
}