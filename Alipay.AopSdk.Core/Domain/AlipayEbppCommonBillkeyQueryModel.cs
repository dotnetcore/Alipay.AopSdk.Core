using System;
using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Domain
{
	/// <summary>
	///     AlipayEbppCommonBillkeyQueryModel Data Structure.
	/// </summary>
	[Serializable]
	public class AlipayEbppCommonBillkeyQueryModel : AopObject
	{
		/// <summary>
		///     业务类型缩写：  JF-缴费
		/// </summary>
		[JsonProperty("biz_type")]
		public string BizType { get; set; }

		/// <summary>
		///     出账机构缩写
		/// </summary>
		[JsonProperty("charge_inst")]
		public string ChargeInst { get; set; }

		/// <summary>
		///     子业务类型英文名称:  ELECTRIC-电力  GAS-燃气  WATER-水
		/// </summary>
		[JsonProperty("sub_biz_type")]
		public string SubBizType { get; set; }
	}
}