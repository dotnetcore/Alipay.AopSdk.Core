using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Response
{
	/// <summary>
	///     AlipayOpenPublicLifeLabelCreateResponse.
	/// </summary>
	public class AlipayOpenPublicLifeLabelCreateResponse : AopResponse
	{
		/// <summary>
		///     标签id
		/// </summary>
		[JsonProperty("label_id")]
		public string LabelId { get; set; }
	}
}