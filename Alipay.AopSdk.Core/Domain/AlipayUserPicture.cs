using System;
using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Domain
{
	/// <summary>
	///     AlipayUserPicture Data Structure.
	/// </summary>
	[Serializable]
	public class AlipayUserPicture : AopObject
	{
		/// <summary>
		///     图片类型，包括身份证正反面、营业执照等
		/// </summary>
		[JsonProperty("picture_type")]
		public string PictureType { get; set; }

		/// <summary>
		///     用于调用alipay.user.certify.image.fetch接口，获取图片资源
		/// </summary>
		[JsonProperty("picture_url")]
		public string PictureUrl { get; set; }
	}
}