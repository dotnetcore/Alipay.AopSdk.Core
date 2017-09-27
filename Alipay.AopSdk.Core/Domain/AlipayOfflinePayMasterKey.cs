using System;
using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Domain
{
	/// <summary>
	///     AlipayOfflinePayMasterKey Data Structure.
	/// </summary>
	[Serializable]
	public class AlipayOfflinePayMasterKey : AopObject
	{
		/// <summary>
		///     秘钥id
		/// </summary>
		[JsonProperty("key_id")]
		public long KeyId { get; set; }

		/// <summary>
		///     支付宝脱机服务公钥
		/// </summary>
		[JsonProperty("public_key")]
		public string PublicKey { get; set; }
	}
}