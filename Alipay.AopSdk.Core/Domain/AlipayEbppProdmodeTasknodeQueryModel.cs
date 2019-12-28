using System;
using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Domain
{
	/// <summary>
	///     AlipayEbppProdmodeTasknodeQueryModel Data Structure.
	/// </summary>
	[Serializable]
	public class AlipayEbppProdmodeTasknodeQueryModel : AopObject
	{
		/// <summary>
		///     任务编号
		/// </summary>
		[JsonProperty("task_id")]
		public string TaskId { get; set; }
	}
}