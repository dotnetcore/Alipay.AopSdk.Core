using System;
using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Domain
{
	/// <summary>
	///     Picture Data Structure.
	/// </summary>
	[Serializable]
	public class Picture : AopObject
	{
		/// <summary>
		///     调用alipay.offline.material.image.upload接口将图片上传到素材中心后，生成的ID
		/// </summary>
		[JsonProperty("location")]
		public string Location { get; set; }

		/// <summary>
		///     图片名称
		/// </summary>
		[JsonProperty("name")]
		public string Name { get; set; }
	}
}