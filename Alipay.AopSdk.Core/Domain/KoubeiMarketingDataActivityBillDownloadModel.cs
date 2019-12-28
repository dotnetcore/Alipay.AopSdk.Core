using System;
using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Domain
{
	/// <summary>
	///     KoubeiMarketingDataActivityBillDownloadModel Data Structure.
	/// </summary>
	[Serializable]
	public class KoubeiMarketingDataActivityBillDownloadModel : AopObject
	{
		/// <summary>
		///     活动id
		/// </summary>
		[JsonProperty("camp_id")]
		public string CampId { get; set; }
	}
}