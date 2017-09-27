using System;
using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Domain
{
	/// <summary>
	///     EquipmentAuthRemoveQueryBypageDTO Data Structure.
	/// </summary>
	[Serializable]
	public class EquipmentAuthRemoveQueryBypageDTO : AopObject
	{
		/// <summary>
		///     机具编号
		/// </summary>
		[JsonProperty("device_id")]
		public string DeviceId { get; set; }

		/// <summary>
		///     解绑时间
		/// </summary>
		[JsonProperty("unbind_time")]
		public string UnbindTime { get; set; }
	}
}