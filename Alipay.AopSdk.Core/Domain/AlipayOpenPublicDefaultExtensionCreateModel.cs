using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Domain
{
	/// <summary>
	///     AlipayOpenPublicDefaultExtensionCreateModel Data Structure.
	/// </summary>
	[Serializable]
	public class AlipayOpenPublicDefaultExtensionCreateModel : AopObject
	{
		/// <summary>
		///     默认扩展区列表，最多包含3个扩展区
		/// </summary>
		[JsonProperty("areas")]
		
		public List<ExtensionArea> Areas { get; set; }
	}
}