using System;
using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Domain
{
	/// <summary>
	///     AlipayKeyanClass Data Structure.
	/// </summary>
	[Serializable]
	public class AlipayKeyanClass : AopObject
	{
		/// <summary>
		///     1
		/// </summary>
		[JsonProperty("user_name")]
		public string UserName { get; set; }
	}
}