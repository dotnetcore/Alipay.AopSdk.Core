using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Domain
{
	/// <summary>
	///     AlipayOfflineProviderMonitorLogSyncModel Data Structure.
	/// </summary>
	[Serializable]
	public class AlipayOfflineProviderMonitorLogSyncModel : AopObject
	{
		/// <summary>
		///     数据回流日志
		/// </summary>
		[JsonProperty("logs")]
		
		public List<ISVLogSync> Logs { get; set; }
	}
}