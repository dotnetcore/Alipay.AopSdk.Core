using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Response
{
	/// <summary>
	///     AlipayUserTestResponse.
	/// </summary>
	public class AlipayUserTestResponse : AopResponse
	{
		/// <summary>
		///     返回值
		/// </summary>
		[XmlElement("ret1")]
		public string Ret1 { get; set; }
	}
}