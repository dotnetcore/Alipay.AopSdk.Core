using System;
using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Domain
{
	/// <summary>
	///     SignTaskResult Data Structure.
	/// </summary>
	[Serializable]
	public class SignTaskResult : AopObject
	{
		/// <summary>
		///     业务流水号
		/// </summary>
		[JsonProperty("biz_id")]
		public string BizId { get; set; }

		/// <summary>
		///     支付宝签约入口地址
		/// </summary>
		[JsonProperty("sign_enter_url")]
		public string SignEnterUrl { get; set; }

		/// <summary>
		///     签名任务流水号
		/// </summary>
		[JsonProperty("task_id")]
		public string TaskId { get; set; }
	}
}