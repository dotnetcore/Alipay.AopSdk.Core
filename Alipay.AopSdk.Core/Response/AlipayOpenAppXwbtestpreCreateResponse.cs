using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Response
{
	/// <summary>
	///     AlipayOpenAppXwbtestpreCreateResponse.
	/// </summary>
	public class AlipayOpenAppXwbtestpreCreateResponse : AopResponse
	{
		/// <summary>
		///     s
		/// </summary>
		[JsonProperty("forestuser")]
		public bool Forestuser { get; set; }

		/// <summary>
		///     1
		/// </summary>
		[JsonProperty("sd")]
		public string Sd { get; set; }

		/// <summary>
		///     1
		/// </summary>
		[JsonProperty("sdd")]
		public string Sdd { get; set; }

		/// <summary>
		///     1
		/// </summary>
		[JsonProperty("sdf")]
		public string Sdf { get; set; }

		/// <summary>
		///     描述
		/// </summary>
		[JsonProperty("sdfsdf")]
		public bool Sdfsdf { get; set; }
	}
}