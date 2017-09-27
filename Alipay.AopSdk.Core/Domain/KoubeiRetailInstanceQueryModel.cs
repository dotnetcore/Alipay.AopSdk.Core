using System;
using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Domain
{
	/// <summary>
	///     KoubeiRetailInstanceQueryModel Data Structure.
	/// </summary>
	[Serializable]
	public class KoubeiRetailInstanceQueryModel : AopObject
	{
		/// <summary>
		///     当前页码，最小1
		/// </summary>
		[JsonProperty("page_num")]
		public long PageNum { get; set; }

		/// <summary>
		///     一次请求返回的数据量，最小1~50整数
		/// </summary>
		[JsonProperty("page_size")]
		public long PageSize { get; set; }
	}
}