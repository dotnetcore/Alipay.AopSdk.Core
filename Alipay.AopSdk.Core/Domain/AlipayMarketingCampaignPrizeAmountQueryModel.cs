using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
	/// <summary>
	///     AlipayMarketingCampaignPrizeAmountQueryModel Data Structure.
	/// </summary>
	[Serializable]
	public class AlipayMarketingCampaignPrizeAmountQueryModel : AopObject
	{
		/// <summary>
		///     活动id
		/// </summary>
		[XmlElement("camp_id")]
		public string CampId { get; set; }

		/// <summary>
		///     奖品id
		/// </summary>
		[XmlElement("prize_id")]
		public string PrizeId { get; set; }
	}
}