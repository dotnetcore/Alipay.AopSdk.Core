using System;
using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Domain
{
	/// <summary>
	///     AlipayHighValueCustomerResult Data Structure.
	/// </summary>
	[Serializable]
	public class AlipayHighValueCustomerResult : AopObject
	{
		/// <summary>
		///     Z0-Z7
		/// </summary>
		[JsonProperty("level")]
		public string Level { get; set; }
	}
}