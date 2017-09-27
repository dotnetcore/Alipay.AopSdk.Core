using System;
using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Domain
{
	/// <summary>
	///     AlipayEcoMycarDialogonlineAnswererUpdateModel Data Structure.
	/// </summary>
	[Serializable]
	public class AlipayEcoMycarDialogonlineAnswererUpdateModel : AopObject
	{
		/// <summary>
		///     技师ID
		/// </summary>
		[JsonProperty("answer_id")]
		public string AnswerId { get; set; }

		/// <summary>
		///     技师状态，0：可用，1：停用
		/// </summary>
		[JsonProperty("answer_status")]
		public string AnswerStatus { get; set; }
	}
}