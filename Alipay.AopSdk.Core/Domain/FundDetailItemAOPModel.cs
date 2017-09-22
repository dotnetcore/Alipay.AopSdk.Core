using System;
using System.Collections.Generic;
using System.Xml.Serialization;

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
		[XmlArray("single_fund_detail_item_aopmodel_list")]
		[XmlArrayItem("single_fund_detail_item_a_o_p_model")]
		public List<SingleFundDetailItemAOPModel> SingleFundDetailItemAopmodelList { get; set; }
	}
}