using System;
using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Domain
{
	/// <summary>
	///     BeaconTemplate Data Structure.
	/// </summary>
	[Serializable]
	public class BeaconTemplate : AopObject
	{
		/// <summary>
		///     模板参数信息
		/// </summary>
		[JsonProperty("context")]
		public string Context { get; set; }

		/// <summary>
		///     模板ID
		/// </summary>
		[JsonProperty("templateid")]
		public string Templateid { get; set; }
	}
}