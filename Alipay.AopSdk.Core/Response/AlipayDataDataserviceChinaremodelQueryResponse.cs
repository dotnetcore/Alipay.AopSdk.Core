using Newtonsoft.Json;
using Alipay.AopSdk.Core.Domain;

namespace Alipay.AopSdk.Core.Response
{
	/// <summary>
	///     AlipayDataDataserviceChinaremodelQueryResponse.
	/// </summary>
	public class AlipayDataDataserviceChinaremodelQueryResponse : AopResponse
	{
		/// <summary>
		///     中再核保模型查询结果
		/// </summary>
		[JsonProperty("result")]
		public AlipayChinareModelResult Result { get; set; }
	}
}