using System;
using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Domain
{
	/// <summary>
	///     CardFrontTextDTO Data Structure.
	/// </summary>
	[Serializable]
	public class CardFrontTextDTO : AopObject
	{
		/// <summary>
		///     文案标签
		/// </summary>
		[JsonProperty("label")]
		public string Label { get; set; }

		/// <summary>
		///     展示文案
		/// </summary>
		[JsonProperty("value")]
		public string Value { get; set; }
	}
}