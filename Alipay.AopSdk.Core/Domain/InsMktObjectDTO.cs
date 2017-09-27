using System;
using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Domain
{
	/// <summary>
	///     InsMktObjectDTO Data Structure.
	/// </summary>
	[Serializable]
	public class InsMktObjectDTO : AopObject
	{
		/// <summary>
		///     活动标的id
		/// </summary>
		[JsonProperty("obj_id")]
		public string ObjId { get; set; }

		/// <summary>
		///     标的类型
		/// </summary>
		[JsonProperty("type")]
		public long Type { get; set; }
	}
}