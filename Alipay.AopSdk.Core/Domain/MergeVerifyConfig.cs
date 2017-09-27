using System;
using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Domain
{
	/// <summary>
	///     MergeVerifyConfig Data Structure.
	/// </summary>
	[Serializable]
	public class MergeVerifyConfig : AopObject
	{
		/// <summary>
		///     可以与任意其他券叠加
		/// </summary>
		[JsonProperty("general_merge_others")]
		public bool GeneralMergeOthers { get; set; }

		/// <summary>
		///     全场和单品叠加标识
		/// </summary>
		[JsonProperty("general_merge_single")]
		public bool GeneralMergeSingle { get; set; }
	}
}