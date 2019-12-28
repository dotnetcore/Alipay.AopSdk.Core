using System;
using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Domain
{
	/// <summary>
	///     ReduceToAmtDstCampPrizeModel Data Structure.
	/// </summary>
	[Serializable]
	public class ReduceToAmtDstCampPrizeModel : AopObject
	{
		/// <summary>
		///     优惠后价格
		/// </summary>
		[JsonProperty("reduct_to_amt")]
		public string ReductToAmt { get; set; }
	}
}