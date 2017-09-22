using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
	/// <summary>
	///     AreaInfo Data Structure.
	/// </summary>
	[Serializable]
	public class AreaInfo : AopObject
	{
		/// <summary>
		///     城市
		/// </summary>
		[XmlElement("city")]
		public string City { get; set; }

		/// <summary>
		///     省份
		/// </summary>
		[XmlElement("province")]
		public string Province { get; set; }
	}
}