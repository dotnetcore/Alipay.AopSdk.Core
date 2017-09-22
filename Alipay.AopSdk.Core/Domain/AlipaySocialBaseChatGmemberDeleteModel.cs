using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
	/// <summary>
	///     AlipaySocialBaseChatGmemberDeleteModel Data Structure.
	/// </summary>
	[Serializable]
	public class AlipaySocialBaseChatGmemberDeleteModel : AopObject
	{
		/// <summary>
		///     群id
		/// </summary>
		[XmlElement("group_id")]
		public string GroupId { get; set; }

		/// <summary>
		///     剔除的群成员用户id列表
		/// </summary>
		[XmlArray("uids")]
		[XmlArrayItem("string")]
		public List<string> Uids { get; set; }
	}
}