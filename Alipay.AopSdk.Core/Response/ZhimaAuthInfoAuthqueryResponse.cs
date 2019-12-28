using Newtonsoft.Json;

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
		[JsonProperty("authorized")]
		public bool Authorized { get; set; }
	}
}