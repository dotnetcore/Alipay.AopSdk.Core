using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Response
{
	/// <summary>
	///     AlipayInsAutoCarSaveResponse.
	/// </summary>
	public class AlipayInsAutoCarSaveResponse : AopResponse
	{
		/// <summary>
		///     车牌号
		/// </summary>
		[JsonProperty("car_no")]
		public string CarNo { get; set; }
	}
}