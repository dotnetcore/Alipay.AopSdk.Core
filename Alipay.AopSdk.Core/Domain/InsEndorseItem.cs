using System;
using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Domain
{
	/// <summary>
	///     InsEndorseItem Data Structure.
	/// </summary>
	[Serializable]
	public class InsEndorseItem : AopObject
	{
		/// <summary>
		///     批单项新值
		/// </summary>
		[JsonProperty("new_value")]
		public string NewValue { get; set; }

		/// <summary>
		///     批单项旧值
		/// </summary>
		[JsonProperty("old_value")]
		public string OldValue { get; set; }

		/// <summary>
		///     批单类型;303:保单改期;311:批改保单标的
		/// </summary>
		[JsonProperty("type")]
		public long Type { get; set; }
	}
}