using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
	/// <summary>
	///     KoubeiRetailShopitemUploadModel Data Structure.
	/// </summary>
	[Serializable]
	public class KoubeiRetailShopitemUploadModel : AopObject
	{
		/// <summary>
		///     上传的商品集合
		/// </summary>
		[XmlArray("shop_items")]
		[XmlArrayItem("request_ext_shop_item")]
		public List<RequestExtShopItem> ShopItems { get; set; }
	}
}