using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Domain
{
	/// <summary>
	///     KbadvertVoucherManual Data Structure.
	/// </summary>
	[Serializable]
	public class KbadvertVoucherManual : AopObject
	{
		/// <summary>
		///     说明
		/// </summary>
		[JsonProperty("details")]
		
		public List<string> Details { get; set; }

		/// <summary>
		///     标题
		/// </summary>
		[JsonProperty("title")]
		public string Title { get; set; }
	}
}