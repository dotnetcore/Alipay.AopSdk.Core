using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
	/// <summary>
	///     AlipayMarketingCampaignDiscountQueryModel Data Structure.
	/// </summary>
	[Serializable]
	public class AlipayMarketingCampaignDiscountQueryModel : AopObject
	{
		/// <summary>
		///     活动id
		/// </summary>
		[XmlElement("camp_id")]
		public string CampId { get; set; }
	}
}