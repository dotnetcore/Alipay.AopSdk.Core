using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
	/// <summary>
	///     KoubeiShopMallPageQueryModel Data Structure.
	/// </summary>
	[Serializable]
	public class KoubeiShopMallPageQueryModel : AopObject
	{
		/// <summary>
		///     商圈id
		/// </summary>
		[XmlElement("mall_id")]
		public string MallId { get; set; }
	}
}