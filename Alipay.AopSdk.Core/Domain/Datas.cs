using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Domain
{
	/// <summary>
	///     Datas Data Structure.
	/// </summary>
	[Serializable]
	public class Datas : AopObject
	{
		/// <summary>
		///     指标数据区
		/// </summary>
		[JsonProperty("data")]
		
		public List<DataEntry> Data { get; set; }

		/// <summary>
		///     数据维度
		/// </summary>
		[JsonProperty("dimension")]
		
		public List<DataDim> Dimension { get; set; }
	}
}