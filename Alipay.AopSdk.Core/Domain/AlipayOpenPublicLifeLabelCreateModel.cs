using System;
using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Domain
{
	/// <summary>
	///     AlipayOpenPublicLifeLabelCreateModel Data Structure.
	/// </summary>
	[Serializable]
	public class AlipayOpenPublicLifeLabelCreateModel : AopObject
	{
		/// <summary>
		///     标签值类型，目前只支持string（字符串类型），不传默认为"string"
		/// </summary>
		[JsonProperty("data_type")]
		public string DataType { get; set; }

		/// <summary>
		///     自定义标签名
		/// </summary>
		[JsonProperty("label_name")]
		public string LabelName { get; set; }
	}
}