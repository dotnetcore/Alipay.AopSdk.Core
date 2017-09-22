using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
	/// <summary>
	///     PidShopInfo Data Structure.
	/// </summary>
	[Serializable]
	public class PidShopInfo : AopObject
	{
		/// <summary>
		///     商户pid
		/// </summary>
		[XmlElement("pid")]
		public string Pid { get; set; }

		/// <summary>
		///     pid下的门店列表
		/// </summary>
		[XmlArray("shop_ids")]
		[XmlArrayItem("string")]
		public List<string> ShopIds { get; set; }
	}
}