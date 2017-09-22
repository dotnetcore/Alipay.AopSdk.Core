using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
	/// <summary>
	///     AlipayEcoCplifeResidentinfoDeleteModel Data Structure.
	/// </summary>
	[Serializable]
	public class AlipayEcoCplifeResidentinfoDeleteModel : AopObject
	{
		/// <summary>
		///     待删除的住户所在的小区ID(支付宝平台统一小区ID标识)
		/// </summary>
		[XmlElement("community_id")]
		public string CommunityId { get; set; }

		/// <summary>
		///     待删除住户在物业系统中的唯一标示,一次至多传入200条用户ID
		/// </summary>
		[XmlArray("out_resident_id_set")]
		[XmlArrayItem("string")]
		public List<string> OutResidentIdSet { get; set; }
	}
}