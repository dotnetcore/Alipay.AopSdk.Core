using System;
using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Domain
{
	/// <summary>
	///     AlipayInsSceneApplicationIssueConfirmModel Data Structure.
	/// </summary>
	[Serializable]
	public class AlipayInsSceneApplicationIssueConfirmModel : AopObject
	{
		/// <summary>
		///     投保订单号
		/// </summary>
		[JsonProperty("application_no")]
		public string ApplicationNo { get; set; }
	}
}