using System;
using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Domain
{
	/// <summary>
	///     ArrangementConditionGroupSelector Data Structure.
	/// </summary>
	[Serializable]
	public class ArrangementConditionGroupSelector : AopObject
	{
		/// <summary>
		///     是否选择最新的产品条件,默认为TRUE
		/// </summary>
		[JsonProperty("select_latest_pd_cd")]
		public bool SelectLatestPdCd { get; set; }
	}
}