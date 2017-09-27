using System;
using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Domain
{
	/// <summary>
	///     AlipayOpenAppXwbtestpreCreateModel Data Structure.
	/// </summary>
	[Serializable]
	public class AlipayOpenAppXwbtestpreCreateModel : AopObject
	{
		/// <summary>
		///     1
		/// </summary>
		[JsonProperty("sd")]
		public string Sd { get; set; }

		/// <summary>
		///     1
		/// </summary>
		[JsonProperty("xwb")]
		public string Xwb { get; set; }
	}
}