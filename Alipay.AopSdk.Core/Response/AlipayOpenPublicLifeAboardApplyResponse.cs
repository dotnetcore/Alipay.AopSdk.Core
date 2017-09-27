using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Response
{
	/// <summary>
	///     AlipayOpenPublicLifeAboardApplyResponse.
	/// </summary>
	public class AlipayOpenPublicLifeAboardApplyResponse : AopResponse
	{
		/// <summary>
		///     上架成功后返回的提示
		/// </summary>
		[JsonProperty("result")]
		public string Result { get; set; }
	}
}