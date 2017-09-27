using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Response
{
	/// <summary>
	///     AlipaySecurityRiskHideDeviceidQueryResponse.
	/// </summary>
	public class AlipaySecurityRiskHideDeviceidQueryResponse : AopResponse
	{
		/// <summary>
		///     设备指纹的apdid
		/// </summary>
		[JsonProperty("deviceid")]
		public string Deviceid { get; set; }
	}
}