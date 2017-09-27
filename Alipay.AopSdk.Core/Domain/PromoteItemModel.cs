using System;
using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Domain
{
	/// <summary>
	///     PromoteItemModel Data Structure.
	/// </summary>
	[Serializable]
	public class PromoteItemModel : AopObject
	{
		/// <summary>
		///     品牌名称
		/// </summary>
		[JsonProperty("brand_name")]
		public string BrandName { get; set; }

		/// <summary>
		///     商户名称
		/// </summary>
		[JsonProperty("merchant_name")]
		public string MerchantName { get; set; }

		/// <summary>
		///     券名称
		/// </summary>
		[JsonProperty("voucher_name")]
		public string VoucherName { get; set; }
	}
}