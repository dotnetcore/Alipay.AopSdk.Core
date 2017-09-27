using System;
using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Domain
{
	/// <summary>
	///     AlipaySocialBaseChatGroupsQueryModel Data Structure.
	/// </summary>
	[Serializable]
	public class AlipaySocialBaseChatGroupsQueryModel : AopObject
	{
		/// <summary>
		///     上次接口返回的key，初始传0
		/// </summary>
		[JsonProperty("last_key")]
		public long LastKey { get; set; }
	}
}