using System.Collections.Generic;
using Newtonsoft.Json;
using Alipay.AopSdk.Core.Domain;

namespace Alipay.AopSdk.Core.Response
{
	/// <summary>
	///     AlipayEcoCplifeRooominfoQueryResponse.
	/// </summary>
	public class AlipayEcoCplifeRooominfoQueryResponse : AopResponse
	{
		/// <summary>
		///     符合条件的小区房屋信息列表.
		/// </summary>
		[JsonProperty("room_info")]
		
		public List<CplifeRoomDetail> RoomInfo { get; set; }
	}
}