using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Domain
{
	/// <summary>
	///     InsProduct Data Structure.
	/// </summary>
	[Serializable]
	public class InsProduct : AopObject
	{
		/// <summary>
		///     险种列表
		/// </summary>
		[JsonProperty("coverages")]
		public InsProdCoverage Coverages { get; set; }

		/// <summary>
		///     是否标准产品
		/// </summary>
		[JsonProperty("is_sp")]
		public bool IsSp { get; set; }

		/// <summary>
		///     保险机构;当产品为标准产品时该值为空
		/// </summary>
		[JsonProperty("merchant")]
		public InsMerchant Merchant { get; set; }

		/// <summary>
		///     产品编码;由蚂蚁保险平台分配,商户通过该产品编码投保特定的保险产品
		/// </summary>
		[JsonProperty("prod_code")]
		public string ProdCode { get; set; }

		/// <summary>
		///     产品描述
		/// </summary>
		[JsonProperty("prod_desc")]
		public string ProdDesc { get; set; }

		/// <summary>
		///     产品名称
		/// </summary>
		[JsonProperty("prod_name")]
		public string ProdName { get; set; }

		/// <summary>
		///     产品版本号
		/// </summary>
		[JsonProperty("prod_version")]
		public string ProdVersion { get; set; }

		/// <summary>
		///     资源项
		/// </summary>
		[JsonProperty("resources")]
		
		public List<InsProdResource> Resources { get; set; }

		/// <summary>
		///     产品简称
		/// </summary>
		[JsonProperty("short_name")]
		public string ShortName { get; set; }

		/// <summary>
		///     标准产品编码;标准产品是不同保险公司同一类型产品的一种抽象
		/// </summary>
		[JsonProperty("sp_code")]
		public string SpCode { get; set; }

		/// <summary>
		///     标记列表
		/// </summary>
		[JsonProperty("tags")]
		
		public List<InsProdTag> Tags { get; set; }
	}
}