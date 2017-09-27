using System;
using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Domain
{
	/// <summary>
	///     KbAdvertContentShareCode Data Structure.
	/// </summary>
	[Serializable]
	public class KbAdvertContentShareCode : AopObject
	{
		/// <summary>
		///     吱口令内容详情
		/// </summary>
		[JsonProperty("share_code_desc")]
		public string ShareCodeDesc { get; set; }
	}
}