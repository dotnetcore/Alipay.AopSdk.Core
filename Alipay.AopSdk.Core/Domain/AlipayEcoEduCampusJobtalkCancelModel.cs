using System;
using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Domain
{
	/// <summary>
	///     AlipayEcoEduCampusJobtalkCancelModel Data Structure.
	/// </summary>
	[Serializable]
	public class AlipayEcoEduCampusJobtalkCancelModel : AopObject
	{
		/// <summary>
		///     备用字段，json格式
		/// </summary>
		[JsonProperty("content_var")]
		public string ContentVar { get; set; }

		/// <summary>
		///     宣讲会来源方id
		/// </summary>
		[JsonProperty("talk_source_code")]
		public string TalkSourceCode { get; set; }

		/// <summary>
		///     宣讲会在合作方的ID
		/// </summary>
		[JsonProperty("talk_source_id")]
		public string TalkSourceId { get; set; }
	}
}