using System;
using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Domain
{
	/// <summary>
	///     CommonDescInfo Data Structure.
	/// </summary>
	[Serializable]
	public class CommonDescInfo : AopObject
	{
		/// <summary>
		///     图片URL地址，最大不超过60K，必须使用https
		/// </summary>
		[JsonProperty("img")]
		public string Img { get; set; }

		/// <summary>
		///     文本描述
		/// </summary>
		[JsonProperty("text")]
		public string Text { get; set; }
	}
}