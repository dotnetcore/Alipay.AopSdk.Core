using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Domain
{
	/// <summary>
	///     KbAdvertCascadeCommissionInfo Data Structure.
	/// </summary>
	[Serializable]
	public class KbAdvertCascadeCommissionInfo : AopObject
	{
		/// <summary>
		///     二级分佣条款信息
		/// </summary>
		[JsonProperty("commission_clause_infos")]
		
		public List<KbAdvertCommissionClause> CommissionClauseInfos { get; set; }

		/// <summary>
		///     二级分佣任务认领人类型  PROMOTER：其他推广者  KOUBEI_PLATFORM：口碑平台
		/// </summary>
		[JsonProperty("commission_user_type")]
		public string CommissionUserType { get; set; }
	}
}