using System;
using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Domain
{
	/// <summary>
	///     AlipaySocialBaseChatGnameModifyModel Data Structure.
	/// </summary>
	[Serializable]
	public class AlipaySocialBaseChatGnameModifyModel : AopObject
	{
		/// <summary>
		///     群id
		/// </summary>
		[JsonProperty("group_id")]
		public string GroupId { get; set; }

		/// <summary>
		///     群名称
		/// </summary>
		[JsonProperty("group_name")]
		public string GroupName { get; set; }
	}
}