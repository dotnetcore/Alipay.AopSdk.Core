using System;
using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Domain
{
	/// <summary>
	///     AlipayBossBaseProcessInstanceQueryModel Data Structure.
	/// </summary>
	[Serializable]
	public class AlipayBossBaseProcessInstanceQueryModel : AopObject
	{
		/// <summary>
		///     流程全局唯一ID
		/// </summary>
		[JsonProperty("puid")]
		public string Puid { get; set; }
	}
}