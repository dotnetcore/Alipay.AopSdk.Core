using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
	/// <summary>
	///     AlipaySocialBaseGroupQueryModel Data Structure.
	/// </summary>
	[Serializable]
	public class AlipaySocialBaseGroupQueryModel : AopObject
	{
		/// <summary>
		///     群的id
		/// </summary>
		[XmlElement("group_id")]
		public string GroupId { get; set; }
	}
}