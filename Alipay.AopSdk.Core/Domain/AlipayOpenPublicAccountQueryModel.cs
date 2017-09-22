using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
	/// <summary>
	///     AlipayOpenPublicAccountQueryModel Data Structure.
	/// </summary>
	[Serializable]
	public class AlipayOpenPublicAccountQueryModel : AopObject
	{
		/// <summary>
		///     支付宝账号userid，2088开头长度为16位的字符串
		/// </summary>
		[XmlElement("user_id")]
		public string UserId { get; set; }
	}
}