using System;
using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Domain
{
	/// <summary>
	///     AlipayCommerceTransportOfflinepayRecordVerifyModel Data Structure.
	/// </summary>
	[Serializable]
	public class AlipayCommerceTransportOfflinepayRecordVerifyModel : AopObject
	{
		/// <summary>
		///     原始脱机记录信息
		/// </summary>
		[JsonProperty("record")]
		public string Record { get; set; }
	}
}