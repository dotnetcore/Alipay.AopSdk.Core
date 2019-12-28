using System;
using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Domain
{
	/// <summary>
	///     EduAgeDemand Data Structure.
	/// </summary>
	[Serializable]
	public class EduAgeDemand : AopObject
	{
		/// <summary>
		///     结束年龄
		/// </summary>
		[JsonProperty("age_end")]
		public string AgeEnd { get; set; }

		/// <summary>
		///     开始年龄
		/// </summary>
		[JsonProperty("age_start")]
		public string AgeStart { get; set; }
	}
}