using System;
using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Domain
{
	/// <summary>
	///     ItemDiagnoseType Data Structure.
	/// </summary>
	[Serializable]
	public class ItemDiagnoseType : AopObject
	{
		/// <summary>
		///     类型
		/// </summary>
		[JsonProperty("item_diagnose")]
		public string ItemDiagnose { get; set; }

		/// <summary>
		///     对类型的描述
		/// </summary>
		[JsonProperty("item_diagnose_desc")]
		public string ItemDiagnoseDesc { get; set; }
	}
}