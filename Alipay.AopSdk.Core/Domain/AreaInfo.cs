using System;
using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Domain
{
	/// <summary>
	///     AreaInfo Data Structure.
	/// </summary>
	[Serializable]
	public class AreaInfo : AopObject
	{
		/// <summary>
		///     城市
		/// </summary>
		[JsonProperty("city")]
		public string City { get; set; }

		/// <summary>
		///     省份
		/// </summary>
		[JsonProperty("province")]
		public string Province { get; set; }
	}
}