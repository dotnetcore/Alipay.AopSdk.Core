using System.Collections.Generic;
using Newtonsoft.Json;
using Alipay.AopSdk.Core.Domain;

namespace Alipay.AopSdk.Core.Response
{
	/// <summary>
	///     KoubeiMarketingCampaignUserAssetQueryResponse.
	/// </summary>
	public class KoubeiMarketingCampaignUserAssetQueryResponse : AopResponse
	{
		/// <summary>
		///     券资产详情信息
		/// </summary>
		[JsonProperty("voucher_asset_list")]
		
		public List<VoucherDetailInfo> VoucherAssetList { get; set; }

		/// <summary>
		///     券资产数量
		/// </summary>
		[JsonProperty("voucher_asset_num")]
		public long VoucherAssetNum { get; set; }
	}
}