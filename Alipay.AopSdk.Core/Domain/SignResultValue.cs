using System;
using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Domain
{
	/// <summary>
	///     SignResultValue Data Structure.
	/// </summary>
	[Serializable]
	public class SignResultValue : AopObject
	{
		/// <summary>
		///     已生效的销账/出账机构
		/// </summary>
		[JsonProperty("effect_biz_value")]
		public string EffectBizValue { get; set; }
	}
}