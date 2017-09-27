using System;
using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Domain
{
	/// <summary>
	///     KbAdvertDealBillResponse Data Structure.
	/// </summary>
	[Serializable]
	public class KbAdvertDealBillResponse : AopObject
	{
		/// <summary>
		///     账单下载地址(为空表示查无账单)
		/// </summary>
		[JsonProperty("download_url")]
		public string DownloadUrl { get; set; }
	}
}