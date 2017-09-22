using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
	/// <summary>
	///     AlipayMarketingCampaignActivityOfflineTriggerModel Data Structure.
	/// </summary>
	[Serializable]
	public class AlipayMarketingCampaignActivityOfflineTriggerModel : AopObject
	{
		/// <summary>
		///     活动id
		/// </summary>
		[XmlElement("camp_id")]
		public string CampId { get; set; }

		/// <summary>
		///     用户id
		/// </summary>
		[XmlElement("user_id")]
		public string UserId { get; set; }
	}
}