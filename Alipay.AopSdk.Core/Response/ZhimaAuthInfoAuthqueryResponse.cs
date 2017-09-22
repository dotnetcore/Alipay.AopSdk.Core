using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Response
{
	/// <summary>
	///     ZhimaAuthInfoAuthqueryResponse.
	/// </summary>
	public class ZhimaAuthInfoAuthqueryResponse : AopResponse
	{
		/// <summary>
		///     是否已经授权,已授权:true,未授权:false
		/// </summary>
		[XmlElement("authorized")]
		public bool Authorized { get; set; }
	}
}