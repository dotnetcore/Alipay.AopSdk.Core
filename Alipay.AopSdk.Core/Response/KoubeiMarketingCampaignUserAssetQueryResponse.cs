using System.Collections.Generic;
using System.Xml.Serialization;
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
		[XmlArray("voucher_asset_list")]
		[XmlArrayItem("voucher_detail_info")]
		public List<VoucherDetailInfo> VoucherAssetList { get; set; }

		/// <summary>
		///     券资产数量
		/// </summary>
		[XmlElement("voucher_asset_num")]
		public long VoucherAssetNum { get; set; }
	}
}