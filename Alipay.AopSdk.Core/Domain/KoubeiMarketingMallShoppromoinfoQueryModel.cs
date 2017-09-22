using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
	/// <summary>
	///     KoubeiMarketingMallShoppromoinfoQueryModel Data Structure.
	/// </summary>
	[Serializable]
	public class KoubeiMarketingMallShoppromoinfoQueryModel : AopObject
	{
		/// <summary>
		///     商圈id
		/// </summary>
		[XmlElement("mall_id")]
		public string MallId { get; set; }

		/// <summary>
		///     商圈下店铺id列表
		/// </summary>
		[XmlArray("shop_ids")]
		[XmlArrayItem("string")]
		public List<string> ShopIds { get; set; }
	}
}