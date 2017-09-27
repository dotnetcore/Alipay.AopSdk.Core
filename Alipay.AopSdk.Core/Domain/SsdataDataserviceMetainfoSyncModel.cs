using System;
using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Domain
{
	/// <summary>
	///     SsdataDataserviceMetainfoSyncModel Data Structure.
	/// </summary>
	[Serializable]
	public class SsdataDataserviceMetainfoSyncModel : AopObject
	{
		/// <summary>
		///     元数据信息
		/// </summary>
		[JsonProperty("meta_info")]
		public string MetaInfo { get; set; }
	}
}