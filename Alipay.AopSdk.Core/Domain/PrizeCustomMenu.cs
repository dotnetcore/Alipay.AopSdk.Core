using System;
using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Domain
{
	/// <summary>
	///     PrizeCustomMenu Data Structure.
	/// </summary>
	[Serializable]
	public class PrizeCustomMenu : AopObject
	{
		/// <summary>
		///     菜单详情
		/// </summary>
		[JsonProperty("text")]
		public string Text { get; set; }

		/// <summary>
		///     菜单名称
		/// </summary>
		[JsonProperty("title")]
		public string Title { get; set; }
	}
}