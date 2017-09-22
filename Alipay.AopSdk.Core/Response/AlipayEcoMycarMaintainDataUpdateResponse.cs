using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Response
{
	/// <summary>
	///     AlipayEcoMycarMaintainDataUpdateResponse.
	/// </summary>
	public class AlipayEcoMycarMaintainDataUpdateResponse : AopResponse
	{
		/// <summary>
		///     具体返回的处理结果
		/// </summary>
		[XmlElement("info")]
		public string Info { get; set; }
	}
}