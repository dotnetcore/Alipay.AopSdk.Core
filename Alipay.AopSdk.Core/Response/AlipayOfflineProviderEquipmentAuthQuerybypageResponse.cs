using System.Collections.Generic;
using Newtonsoft.Json;
using Alipay.AopSdk.Core.Domain;

namespace Alipay.AopSdk.Core.Response
{
	/// <summary>
	///     AlipayOfflineProviderEquipmentAuthQuerybypageResponse.
	/// </summary>
	public class AlipayOfflineProviderEquipmentAuthQuerybypageResponse : AopResponse
	{
		/// <summary>
		///     机具解绑按照条件分页查询返回信息
		/// </summary>
		[JsonProperty("equipmentauthremovequerybypagelist")]
		
		public List<EquipmentAuthRemoveQueryBypageDTO> Equipmentauthremovequerybypagelist { get; set; }

		/// <summary>
		///     总记录数
		/// </summary>
		[JsonProperty("total")]
		public long Total { get; set; }
	}
}