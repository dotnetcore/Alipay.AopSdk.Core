using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Domain
{
	/// <summary>
	///     AlipaySocialBaseChatGinvSendModel Data Structure.
	/// </summary>
	[Serializable]
	public class AlipaySocialBaseChatGinvSendModel : AopObject
	{
		/// <summary>
		///     群id
		/// </summary>
		[JsonProperty("group_id")]
		public string GroupId { get; set; }

		/// <summary>
		///     邀请的好友id列表，最多50人
		/// </summary>
		[JsonProperty("uids")]
		
		public List<string> Uids { get; set; }
	}
}