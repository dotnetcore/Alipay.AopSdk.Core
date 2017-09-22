using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Response
{
	/// <summary>
	///     AlipayOpenAppPackagetestResponse.
	/// </summary>
	public class AlipayOpenAppPackagetestResponse : AopResponse
	{
		/// <summary>
		///     testtest
		/// </summary>
		[XmlElement("testtesttesttest")]
		public string Testtesttesttest { get; set; }
	}
}