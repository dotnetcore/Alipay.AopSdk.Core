using System.Collections.Generic;
using System.Xml.Serialization;
using Alipay.AopSdk.Core.Domain;

namespace Alipay.AopSdk.Core.Response
{
	/// <summary>
	///     AlipayDataDataexchangeSfasdfResponse.
	/// </summary>
	public class AlipayDataDataexchangeSfasdfResponse : AopResponse
	{
		/// <summary>
		///     dsfagshdj
		/// </summary>
		[XmlArray("azxfghd")]
		[XmlArrayItem("string")]
		public List<string> Azxfghd { get; set; }

		/// <summary>
		///     asghdfsdas阿福故事、
		/// </summary>
		[XmlArray("gfdhsdasafg")]
		[XmlArrayItem("string")]
		public List<string> Gfdhsdasafg { get; set; }

		/// <summary>
		///     fgdhjdsfgh
		/// </summary>
		[XmlArray("gfhjfdsa")]
		[XmlArrayItem("string")]
		public List<string> Gfhjfdsa { get; set; }

		/// <summary>
		///     sdfdhgjfdfsaghjfd
		/// </summary>
		[XmlArray("ghjfdsafgh")]
		[XmlArrayItem("string")]
		public List<string> Ghjfdsafgh { get; set; }

		/// <summary>
		///     sadasff
		/// </summary>
		[XmlElement("sdvsdv")]
		public string Sdvsdv { get; set; }

		/// <summary>
		///     hysasd
		/// </summary>
		[XmlArray("wrty")]
		[XmlArrayItem("alipay_item_goods_list")]
		public List<AlipayItemGoodsList> Wrty { get; set; }
	}
}