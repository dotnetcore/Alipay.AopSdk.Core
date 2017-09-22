using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
	/// <summary>
	///     KbAdvertContentShareCode Data Structure.
	/// </summary>
	[Serializable]
	public class KbAdvertContentShareCode : AopObject
	{
		/// <summary>
		///     吱口令内容详情
		/// </summary>
		[XmlElement("share_code_desc")]
		public string ShareCodeDesc { get; set; }
	}
}