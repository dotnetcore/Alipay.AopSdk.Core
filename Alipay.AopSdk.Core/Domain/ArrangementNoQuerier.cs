using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Domain
{
	/// <summary>
	///     ArrangementNoQuerier Data Structure.
	/// </summary>
	[Serializable]
	public class ArrangementNoQuerier : AopObject
	{
		/// <summary>
		///     合约编号列表
		/// </summary>
		[JsonProperty("ar_nos")]
		
		public List<string> ArNos { get; set; }
	}
}