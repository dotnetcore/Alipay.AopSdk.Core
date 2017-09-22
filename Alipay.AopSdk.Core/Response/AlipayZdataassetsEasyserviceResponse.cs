using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Response
{
	/// <summary>
	///     AlipayZdataassetsEasyserviceResponse.
	/// </summary>
	public class AlipayZdataassetsEasyserviceResponse : AopResponse
	{
		/// <summary>
		///     返回结果
		/// </summary>
		[XmlElement("result")]
		public string Result { get; set; }
	}
}