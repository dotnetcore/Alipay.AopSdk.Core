using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// CreditPayInstallmentDetailVO Data Structure.
    /// </summary>
    [Serializable]
    public class CreditPayInstallmentDetailVO : AopObject
    {
        /// <summary>
        /// 费用详情列表，部分分期方案可能不存在费用
        /// </summary>
        [XmlArray("charge_pricing_list")]
        [XmlArrayItem("credit_pay_charge_pricing_v_o")]
        public List<CreditPayChargePricingVO> ChargePricingList { get; set; }

        /// <summary>
        /// 条款列表，条款信息不是必定存在的
        /// </summary>
        [XmlArray("clauses")]
        [XmlArrayItem("credit_pay_clause_v_o")]
        public List<CreditPayClauseVO> Clauses { get; set; }

        /// <summary>
        /// 优惠信息，部分分期方案可能不存在营销信息
        /// </summary>
        [XmlElement("discount_info")]
        public CreditPayDiscountVO DiscountInfo { get; set; }

        /// <summary>
        /// 分期间隔
        /// </summary>
        [XmlElement("instal_itrv")]
        public string InstalItrv { get; set; }

        /// <summary>
        /// 分期间隔类型，年月日(YMD)
        /// </summary>
        [XmlElement("instal_type")]
        public string InstalType { get; set; }

        /// <summary>
        /// 分期ID
        /// </summary>
        [XmlElement("installment_id")]
        public string InstallmentId { get; set; }

        /// <summary>
        /// 利息详情，部分分期方案可能不存在利息
        /// </summary>
        [XmlElement("int_pricing")]
        public CreditPayIntPricingVO IntPricing { get; set; }

        /// <summary>
        /// 渲染模式，INTREST-利息版，INT_RATE-利率版
        /// </summary>
        [XmlElement("render_strategy")]
        public string RenderStrategy { get; set; }

        /// <summary>
        /// 还款信息
        /// </summary>
        [XmlElement("repay_info")]
        public CreditPayRepayVO RepayInfo { get; set; }

        /// <summary>
        /// 分期产品码
        /// </summary>
        [XmlElement("sale_pd_code")]
        public string SalePdCode { get; set; }

        /// <summary>
        /// 分期签名，用于标识一组分期方案中唯一的期限信息,组成方式为sale_pd_code^repay_mode^term^term_unit
        /// </summary>
        [XmlElement("scheme_sign")]
        public string SchemeSign { get; set; }

        /// <summary>
        /// 期限信息
        /// </summary>
        [XmlElement("term_info")]
        public CreditPayTermVO TermInfo { get; set; }
    }
}
