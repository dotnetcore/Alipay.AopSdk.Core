using System.Xml.Serialization;
using Alipay.AopSdk.Core.Domain;

namespace Alipay.AopSdk.Core.Response
{
	/// <summary>
	///     AlipayMarketingToolFengdieActivityQueryResponse.
	/// </summary>
	public class AlipayMarketingToolFengdieActivityQueryResponse : AopResponse
	{
		/// <summary>
		///     H5应用详情
		/// </summary>
		[XmlElement("activity")]
		public FengdieActivity Activity { get; set; }
	}
}