using System;
using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Domain
{
	/// <summary>
	///     KoubeiMarketingCampaignVoucherDetailQueryModel Data Structure.
	/// </summary>
	[Serializable]
	public class KoubeiMarketingCampaignVoucherDetailQueryModel : AopObject
	{
		/// <summary>
		///     支付宝用户id
		/// </summary>
		[JsonProperty("user_id")]
		public string UserId { get; set; }

		/// <summary>
		///     券id
		/// </summary>
		[JsonProperty("voucher_id")]
		public string VoucherId { get; set; }
	}
}