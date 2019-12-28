using System;
using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Domain
{
	/// <summary>
	///     Image Data Structure.
	/// </summary>
	[Serializable]
	public class Image : AopObject
	{
		/// <summary>
		///     图片url，请先调用alipay.offline.material.image.upload 图片上传接口获得图片url
		/// </summary>
		[JsonProperty("url")]
		public string Url { get; set; }
	}
}