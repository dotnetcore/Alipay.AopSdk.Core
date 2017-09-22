using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
	/// <summary>
	///     AlipayEcoMycarPromoTicketSyncModel Data Structure.
	/// </summary>
	[Serializable]
	public class AlipayEcoMycarPromoTicketSyncModel : AopObject
	{
		/// <summary>
		///     营销活动ID
		/// </summary>
		[XmlElement("active_id")]
		public string ActiveId { get; set; }

		/// <summary>
		///     需要同步的卡券信息
		/// </summary>
		[XmlArray("code_no_list")]
		[XmlArrayItem("code_n_o_list")]
		public List<CodeNOList> CodeNoList { get; set; }

		/// <summary>
		///     卡券来源
		/// </summary>
		[XmlElement("source_type")]
		public string SourceType { get; set; }
	}
}