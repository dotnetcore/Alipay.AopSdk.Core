using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Domain
{
	/// <summary>
	///     AlipayPlatformUseridGetModel Data Structure.
	/// </summary>
	[Serializable]
	public class AlipayPlatformUseridGetModel : AopObject
	{
		/// <summary>
		///     openId的列表
		/// </summary>
		[JsonProperty("open_ids")]
		
		public List<string> OpenIds { get; set; }
	}
}