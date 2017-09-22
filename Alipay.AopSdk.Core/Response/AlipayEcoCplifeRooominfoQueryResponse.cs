using System.Collections.Generic;
using System.Xml.Serialization;
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
		[XmlArray("room_info")]
		[XmlArrayItem("cplife_room_detail")]
		public List<CplifeRoomDetail> RoomInfo { get; set; }
	}
}