using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Response
{
	/// <summary>
	///     AlipayEcardEduPublicBindResponse.
	/// </summary>
	public class AlipayEcardEduPublicBindResponse : AopResponse
	{
		/// <summary>
		///     机构编码
		/// </summary>
		[JsonProperty("agent_code")]
		public string AgentCode { get; set; }

		/// <summary>
		///     卡号
		/// </summary>
		[JsonProperty("card_no")]
		public string CardNo { get; set; }

		/// <summary>
		///     成功
		/// </summary>
		[JsonProperty("return_code")]
		public string ReturnCode { get; set; }
	}
}