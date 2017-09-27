using System;
using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Domain
{
	/// <summary>
	///     AlipayOpenPublicLifeLabelDeleteModel Data Structure.
	/// </summary>
	[Serializable]
	public class AlipayOpenPublicLifeLabelDeleteModel : AopObject
	{
		/// <summary>
		///     标签id, 只支持生活号自定义标签
		/// </summary>
		[JsonProperty("label_id")]
		public string LabelId { get; set; }
	}
}