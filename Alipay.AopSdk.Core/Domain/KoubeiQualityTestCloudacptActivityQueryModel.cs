using System;
using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Domain
{
	/// <summary>
	///     KoubeiQualityTestCloudacptActivityQueryModel Data Structure.
	/// </summary>
	[Serializable]
	public class KoubeiQualityTestCloudacptActivityQueryModel : AopObject
	{
		/// <summary>
		///     partener id
		/// </summary>
		[JsonProperty("pid")]
		public string Pid { get; set; }

		/// <summary>
		///     user id
		/// </summary>
		[JsonProperty("uid")]
		public string Uid { get; set; }
	}
}