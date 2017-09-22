using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
	/// <summary>
	///     KoubeiAdvertCommissionAdvchannelUnbindModel Data Structure.
	/// </summary>
	[Serializable]
	public class KoubeiAdvertCommissionAdvchannelUnbindModel : AopObject
	{
		/// <summary>
		///     广告ID
		/// </summary>
		[XmlElement("adv_id")]
		public string AdvId { get; set; }

		/// <summary>
		///     渠道ID列表
		/// </summary>
		[XmlArray("channel_id_list")]
		[XmlArrayItem("string")]
		public List<string> ChannelIdList { get; set; }
	}
}