using System;
using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Domain
{
	/// <summary>
	///     AlipayOpenPublicGroupDeleteModel Data Structure.
	/// </summary>
	[Serializable]
	public class AlipayOpenPublicGroupDeleteModel : AopObject
	{
		/// <summary>
		///     需要删除的用户分组的id
		/// </summary>
		[JsonProperty("group_id")]
		public string GroupId { get; set; }
	}
}