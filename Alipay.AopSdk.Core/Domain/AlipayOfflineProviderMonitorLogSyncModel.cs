using System;
using System.Collections.Generic;
using System.Xml.Serialization;

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
		[XmlArray("logs")]
		[XmlArrayItem("i_s_v_log_sync")]
		public List<ISVLogSync> Logs { get; set; }
	}
}