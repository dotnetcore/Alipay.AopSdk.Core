using System;
using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Domain
{
	/// <summary>
	///     AlipayInsSceneApplicationCancelModel Data Structure.
	/// </summary>
	[Serializable]
	public class AlipayInsSceneApplicationCancelModel : AopObject
	{
		/// <summary>
		///     投保订单号
		/// </summary>
		[JsonProperty("application_no")]
		public string ApplicationNo { get; set; }
	}
}