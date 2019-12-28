using System;
using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Domain
{
	/// <summary>
	///     AlipaySecurityDataInfoMobilecityQueryModel Data Structure.
	/// </summary>
	[Serializable]
	public class AlipaySecurityDataInfoMobilecityQueryModel : AopObject
	{
		/// <summary>
		///     电话号码
		/// </summary>
		[JsonProperty("phone")]
		public string Phone { get; set; }
	}
}