using System;
using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Domain
{
	/// <summary>
	///     AlipaySocialBaseChatGnoticeModifyModel Data Structure.
	/// </summary>
	[Serializable]
	public class AlipaySocialBaseChatGnoticeModifyModel : AopObject
	{
		/// <summary>
		///     群id
		/// </summary>
		[JsonProperty("group_id")]
		public string GroupId { get; set; }

		/// <summary>
		///     群公告
		/// </summary>
		[JsonProperty("group_notice")]
		public string GroupNotice { get; set; }
	}
}