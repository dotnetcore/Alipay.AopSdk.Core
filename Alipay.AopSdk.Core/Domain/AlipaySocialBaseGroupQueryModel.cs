using System;
using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Domain
{
	/// <summary>
	///     AlipaySocialBaseGroupQueryModel Data Structure.
	/// </summary>
	[Serializable]
	public class AlipaySocialBaseGroupQueryModel : AopObject
	{
		/// <summary>
		///     群的id
		/// </summary>
		[JsonProperty("group_id")]
		public string GroupId { get; set; }
	}
}