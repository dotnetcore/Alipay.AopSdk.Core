using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Response
{
	/// <summary>
	///     AlipayEcoMycarDataExternalSendResponse.
	/// </summary>
	public class AlipayEcoMycarDataExternalSendResponse : AopResponse
	{
		/// <summary>
		///     20
		/// </summary>
		[JsonProperty("external_system_name")]
		public string ExternalSystemName { get; set; }

		/// <summary>
		///     outter_response
		/// </summary>
		[JsonProperty("process_result")]
		public string ProcessResult { get; set; }
	}
}