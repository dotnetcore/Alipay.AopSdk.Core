using System;
using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Domain
{
	/// <summary>
	///     SsdataDataserviceRiskAlixiaohaoQueryModel Data Structure.
	/// </summary>
	[Serializable]
	public class SsdataDataserviceRiskAlixiaohaoQueryModel : AopObject
	{
		/// <summary>
		///     电话号码
		/// </summary>
		[JsonProperty("mobile_no")]
		public string MobileNo { get; set; }
	}
}