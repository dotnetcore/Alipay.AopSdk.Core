using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Response
{
	/// <summary>
	///     AntMerchantExpandImageUploadResponse.
	/// </summary>
	public class AntMerchantExpandImageUploadResponse : AopResponse
	{
		/// <summary>
		///     图片在sfs中的标识
		/// </summary>
		[JsonProperty("image_id")]
		public string ImageId { get; set; }
	}
}