using System;
using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Domain
{
	/// <summary>
	///     KbAdvertContentShareCodeModify Data Structure.
	/// </summary>
	[Serializable]
	public class KbAdvertContentShareCodeModify : AopObject
	{
		/// <summary>
		///     宣传展示标题（不能超过30个字符）
		/// </summary>
		[JsonProperty("display_title")]
		public string DisplayTitle { get; set; }
	}
}