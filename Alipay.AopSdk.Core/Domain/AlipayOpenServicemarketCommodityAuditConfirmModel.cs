using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
	/// <summary>
	///     AlipayOpenServicemarketCommodityAuditConfirmModel Data Structure.
	/// </summary>
	[Serializable]
	public class AlipayOpenServicemarketCommodityAuditConfirmModel : AopObject
	{
		/// <summary>
		///     服务插件ID
		/// </summary>
		[XmlElement("commodity_id")]
		public string CommodityId { get; set; }

		/// <summary>
		///     用户ID
		/// </summary>
		[XmlElement("user_id")]
		public string UserId { get; set; }
	}
}