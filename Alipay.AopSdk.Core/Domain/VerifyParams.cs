using System;
using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Domain
{
	/// <summary>
	///     VerifyParams Data Structure.
	/// </summary>
	[Serializable]
	public class VerifyParams : AopObject
	{
		/// <summary>
		///     用户证件号后4位
		/// </summary>
		[JsonProperty("cert_no")]
		public string CertNo { get; set; }
	}
}