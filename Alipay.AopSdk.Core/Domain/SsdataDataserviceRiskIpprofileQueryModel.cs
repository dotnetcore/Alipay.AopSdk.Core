using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
	/// <summary>
	///     SsdataDataserviceRiskIpprofileQueryModel Data Structure.
	/// </summary>
	[Serializable]
	public class SsdataDataserviceRiskIpprofileQueryModel : AopObject
	{
		/// <summary>
		///     IP地址
		/// </summary>
		[XmlElement("ip_address")]
		public string IpAddress { get; set; }

		/// <summary>
		///     手机号码
		/// </summary>
		[XmlElement("phone")]
		public string Phone { get; set; }
	}
}