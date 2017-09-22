using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
	/// <summary>
	///     AlipayEbppProdmodeChargeoffinstQueryModel Data Structure.
	/// </summary>
	[Serializable]
	public class AlipayEbppProdmodeChargeoffinstQueryModel : AopObject
	{
		/// <summary>
		///     业务类型
		/// </summary>
		[XmlElement("biz_type")]
		public string BizType { get; set; }
	}
}