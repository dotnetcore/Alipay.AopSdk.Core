using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Response
{
	/// <summary>
	///     AlipayOpenPublicLifeDebarkApplyResponse.
	/// </summary>
	public class AlipayOpenPublicLifeDebarkApplyResponse : AopResponse
	{
		/// <summary>
		///     下架成功后返回的提示
		/// </summary>
		[JsonProperty("result")]
		public string Result { get; set; }
	}
}