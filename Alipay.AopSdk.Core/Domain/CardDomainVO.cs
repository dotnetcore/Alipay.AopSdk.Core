using System;
using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Domain
{
	/// <summary>
	///     CardDomainVO Data Structure.
	/// </summary>
	[Serializable]
	public class CardDomainVO : AopObject
	{
		/// <summary>
		///     值域域名的描述值，固定为”金融”
		/// </summary>
		[JsonProperty("description")]
		public string Description { get; set; }

		/// <summary>
		///     值域域名，固定为“FINANCE”
		/// </summary>
		[JsonProperty("domain_name")]
		public string DomainName { get; set; }
	}
}