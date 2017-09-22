using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
	/// <summary>
	///     KoubeiQualityTestCloudacptActivityQueryModel Data Structure.
	/// </summary>
	[Serializable]
	public class KoubeiQualityTestCloudacptActivityQueryModel : AopObject
	{
		/// <summary>
		///     partener id
		/// </summary>
		[XmlElement("pid")]
		public string Pid { get; set; }

		/// <summary>
		///     user id
		/// </summary>
		[XmlElement("uid")]
		public string Uid { get; set; }
	}
}