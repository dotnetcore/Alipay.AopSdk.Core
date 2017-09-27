using System;
using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Domain
{
	/// <summary>
	///     AlipayOpenAppPackagetestModel Data Structure.
	/// </summary>
	[Serializable]
	public class AlipayOpenAppPackagetestModel : AopObject
	{
		/// <summary>
		///     testtest
		/// </summary>
		[JsonProperty("testparam")]
		public string Testparam { get; set; }

		/// <summary>
		///     testtest
		/// </summary>
		[JsonProperty("testtest")]
		public string Testtest { get; set; }
	}
}