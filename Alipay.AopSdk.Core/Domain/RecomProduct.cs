using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// RecomProduct Data Structure.
    /// </summary>
    [Serializable]
    public class RecomProduct : AopObject
    {
        /// <summary>
        /// 裸价
        /// </summary>
        [XmlElement("base_premium")]
        public long BasePremium { get; set; }

        /// <summary>
        /// 业务扩展信息
        /// </summary>
        [XmlElement("biz_data")]
        public string BizData { get; set; }

        /// <summary>
        /// 机构ID
        /// </summary>
        [XmlElement("company_id")]
        public string CompanyId { get; set; }

        /// <summary>
        /// 保险公司名称
        /// </summary>
        [XmlElement("company_name")]
        public string CompanyName { get; set; }

        /// <summary>
        /// 保险公司淘宝卖家ID
        /// </summary>
        [XmlElement("company_seller_id")]
        public string CompanySellerId { get; set; }

        /// <summary>
        /// 保险公司淘宝店铺名称
        /// </summary>
        [XmlElement("company_seller_nick")]
        public string CompanySellerNick { get; set; }

        /// <summary>
        /// 保险公司服务电话
        /// </summary>
        [XmlElement("company_service_phone")]
        public string CompanyServicePhone { get; set; }

        /// <summary>
        /// 产品销售单元
        /// </summary>
        [XmlElement("csu_no")]
        public string CsuNo { get; set; }

        /// <summary>
        /// 最大允许购买份数
        /// </summary>
        [XmlElement("max_quan")]
        public long MaxQuan { get; set; }

        /// <summary>
        /// 推荐产品展示名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 推荐方案列表
        /// </summary>
        [XmlElement("plans")]
        public RecomPlan Plans { get; set; }

        /// <summary>
        /// 推荐返回保费，单位分
        /// </summary>
        [XmlElement("premium")]
        public long Premium { get; set; }

        /// <summary>
        /// 推荐产品ID
        /// </summary>
        [XmlElement("prod_no")]
        public string ProdNo { get; set; }

        /// <summary>
        /// 产品资源项列表，可以平行扩展多个资源项
        /// </summary>
        [XmlArray("resource_list")]
        [XmlArrayItem("prod_resource")]
        public List<ProdResource> ResourceList { get; set; }

        /// <summary>
        /// 产品资源项列表
        /// </summary>
        [XmlElement("resources")]
        public ProdResource Resources { get; set; }

        /// <summary>
        /// 按订单维度限购
        /// </summary>
        [XmlElement("restriction_type")]
        public string RestrictionType { get; set; }

        /// <summary>
        /// 保额(单位:分)
        /// </summary>
        [XmlElement("sum_insured")]
        public long SumInsured { get; set; }

        /// <summary>
        /// 推荐返回结果对象：1：保险产品，2：保险权益
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }
    }
}
