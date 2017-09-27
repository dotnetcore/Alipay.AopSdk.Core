using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Domain
{
	/// <summary>
	///     IsvMerchantInfo Data Structure.
	/// </summary>
	[Serializable]
	public class IsvMerchantInfo : AopObject
	{
		/// <summary>
		///     商户pid
		/// </summary>
		[JsonProperty("partner_id")]
		public string PartnerId { get; set; }

		/// <summary>
		///     门店ID列表
		/// </summary>
		[JsonProperty("shop_ids")]
		
		public List<string> ShopIds { get; set; }
	}
}