using System;
using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Domain
{
	/// <summary>
	///     NewsfeedMediaImg Data Structure.
	/// </summary>
	[Serializable]
	public class NewsfeedMediaImg : AopObject
	{
		/// <summary>
		///     图片高度
		/// </summary>
		[JsonProperty("height")]
		public string Height { get; set; }

		/// <summary>
		///     图片地址
		/// </summary>
		[JsonProperty("src")]
		public string Src { get; set; }

		/// <summary>
		///     图片宽度
		/// </summary>
		[JsonProperty("width")]
		public string Width { get; set; }
	}
}