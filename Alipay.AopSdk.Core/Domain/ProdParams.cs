using System;
using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Domain
{
	/// <summary>
	///     ProdParams Data Structure.
	/// </summary>
	[Serializable]
	public class ProdParams : AopObject
	{
		/// <summary>
		///     预授权业务信息
		/// </summary>
		[JsonProperty("auth_biz_params")]
		public string AuthBizParams { get; set; }
	}
}