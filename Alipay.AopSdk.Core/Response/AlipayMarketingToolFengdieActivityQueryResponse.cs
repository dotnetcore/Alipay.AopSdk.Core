using Newtonsoft.Json;
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
		[JsonProperty("activity")]
		public FengdieActivity Activity { get; set; }
	}
}