using System;
using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Domain
{
	/// <summary>
	///     AlipayEcoMycarCarmodelQueryModel Data Structure.
	/// </summary>
	[Serializable]
	public class AlipayEcoMycarCarmodelQueryModel : AopObject
	{
		/// <summary>
		///     支付宝车型库车型编号,系统唯一。
		/// </summary>
		[JsonProperty("model_id")]
		public string ModelId { get; set; }
	}
}