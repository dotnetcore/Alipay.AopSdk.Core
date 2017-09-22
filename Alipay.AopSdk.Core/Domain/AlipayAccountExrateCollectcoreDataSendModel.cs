using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
	/// <summary>
	///     AlipayAccountExrateCollectcoreDataSendModel Data Structure.
	/// </summary>
	[Serializable]
	public class AlipayAccountExrateCollectcoreDataSendModel : AopObject
	{
		/// <summary>
		///     上数提交数据内容
		/// </summary>
		[XmlElement("content")]
		public string Content { get; set; }
	}
}