using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
	/// <summary>
	///     AlipayCommerceTransportOfflinepayRecordVerifyModel Data Structure.
	/// </summary>
	[Serializable]
	public class AlipayCommerceTransportOfflinepayRecordVerifyModel : AopObject
	{
		/// <summary>
		///     原始脱机记录信息
		/// </summary>
		[XmlElement("record")]
		public string Record { get; set; }
	}
}