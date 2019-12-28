using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Response
{
	/// <summary>
	///     MonitorHeartbeatSynResponse.
	/// </summary>
	public class MonitorHeartbeatSynResponse : AopResponse
	{
		/// <summary>
		///     商户pid
		/// </summary>
		[JsonProperty("pid")]
		public string Pid { get; set; }
	}
}