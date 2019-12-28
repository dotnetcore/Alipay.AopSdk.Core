using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Domain
{
	/// <summary>
	///     FundDetailItemAOPModel Data Structure.
	/// </summary>
	[Serializable]
	public class FundDetailItemAOPModel : AopObject
	{
		/// <summary>
		///     主记录+对应资金明细信息模型列表
		/// </summary>
		[JsonProperty("single_fund_detail_item_aopmodel_list")]
		
		public List<SingleFundDetailItemAOPModel> SingleFundDetailItemAopmodelList { get; set; }
	}
}