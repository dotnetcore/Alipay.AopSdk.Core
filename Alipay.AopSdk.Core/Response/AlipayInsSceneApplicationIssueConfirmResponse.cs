using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Response
{
	/// <summary>
	///     AlipayInsSceneApplicationIssueConfirmResponse.
	/// </summary>
	public class AlipayInsSceneApplicationIssueConfirmResponse : AopResponse
	{
		/// <summary>
		///     投保订单号
		/// </summary>
		[JsonProperty("application_no")]
		public string ApplicationNo { get; set; }
	}
}