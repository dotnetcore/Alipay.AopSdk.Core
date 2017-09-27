using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Domain
{
	/// <summary>
	///     InstallmentValue Data Structure.
	/// </summary>
	[Serializable]
	public class InstallmentValue : AopObject
	{
		/// <summary>
		///     分段值
		/// </summary>
		[JsonProperty("installment_values")]
		
		public List<InstallmentMetaInfo> InstallmentValues { get; set; }
	}
}