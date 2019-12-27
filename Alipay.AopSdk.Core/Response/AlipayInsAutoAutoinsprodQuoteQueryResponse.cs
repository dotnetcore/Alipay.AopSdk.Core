using System.Collections.Generic;
using System.Xml.Serialization;
using Alipay.AopSdk.Core.Domain;

namespace Alipay.AopSdk.Core.Response
{
    /// <summary>
    /// AlipayInsAutoAutoinsprodQuoteQueryResponse.
    /// </summary>
    public class AlipayInsAutoAutoinsprodQuoteQueryResponse : AopResponse
    {
        /// <summary>
        /// 商业费率浮动系数，0~1分值的数字，精确到小数点后4位，如：0.6589
        /// </summary>
        [XmlElement("biz_discount")]
        public string BizDiscount { get; set; }

        /// <summary>
        /// 商业险续保标识,  1：新保；2：续保；3：转保
        /// </summary>
        [XmlElement("biz_renewal_flag")]
        public string BizRenewalFlag { get; set; }

        /// <summary>
        /// 商业险续保公司名称
        /// </summary>
        [XmlElement("biz_renewal_org")]
        public string BizRenewalOrg { get; set; }

        /// <summary>
        /// 商业险保费
        /// </summary>
        [XmlElement("business_premium")]
        public string BusinessPremium { get; set; }

        /// <summary>
        /// 商业险产品信息
        /// </summary>
        [XmlElement("business_product")]
        public InsProduct BusinessProduct { get; set; }

        /// <summary>
        /// 车辆信息
        /// </summary>
        [XmlElement("car")]
        public Car Car { get; set; }

        /// <summary>
        /// 车主评分，分值为1-100数字，精确到个位，如：92
        /// </summary>
        [XmlElement("car_owner_grade")]
        public string CarOwnerGrade { get; set; }

        /// <summary>
        /// 如果是图片验证码问题，返回验证码的base64流
        /// </summary>
        [XmlElement("check_code")]
        public string CheckCode { get; set; }

        /// <summary>
        /// 图片验证码标识
        /// </summary>
        [XmlElement("check_code_id")]
        public string CheckCodeId { get; set; }

        /// <summary>
        /// 0-不需要、1-江苏验证码、2-中保信验证码
        /// </summary>
        [XmlElement("check_code_type")]
        public string CheckCodeType { get; set; }

        /// <summary>
        /// 保险公司ID
        /// </summary>
        [XmlElement("com_id")]
        public string ComId { get; set; }

        /// <summary>
        /// 保险公司简称
        /// </summary>
        [XmlElement("com_name")]
        public string ComName { get; set; }

        /// <summary>
        /// 正确车险信息
        /// </summary>
        [XmlArray("correct_car_models")]
        [XmlArrayItem("car_model")]
        public List<CarModel> CorrectCarModels { get; set; }

        /// <summary>
        /// 车险询价申请号
        /// </summary>
        [XmlElement("enquiry_biz_id")]
        public string EnquiryBizId { get; set; }

        /// <summary>
        /// 交强费率浮动系数，0~1分值的数字，精确到小数点后4位，如：0.6589
        /// </summary>
        [XmlElement("force_discount")]
        public string ForceDiscount { get; set; }

        /// <summary>
        /// 交强险保费
        /// </summary>
        [XmlElement("force_premium")]
        public string ForcePremium { get; set; }

        /// <summary>
        /// 交强险产品信息
        /// </summary>
        [XmlElement("force_product")]
        public InsProduct ForceProduct { get; set; }

        /// <summary>
        /// 交强险续保标识; 1：新保；2：续保；3：转保
        /// </summary>
        [XmlElement("force_renewal_flag")]
        public string ForceRenewalFlag { get; set; }

        /// <summary>
        /// 交强险续保公司名称
        /// </summary>
        [XmlElement("force_renewal_org")]
        public string ForceRenewalOrg { get; set; }

        /// <summary>
        /// 支持的物流配送方式
        /// </summary>
        [XmlArray("logistics_models")]
        [XmlArrayItem("string")]
        public List<string> LogisticsModels { get; set; }

        /// <summary>
        /// 平台NCD系数，精确到小数点后两位
        /// </summary>
        [XmlElement("no_claim_adjust_ratio")]
        public string NoClaimAdjustRatio { get; set; }

        /// <summary>
        /// 报价ID
        /// </summary>
        [XmlElement("quote_biz_id")]
        public string QuoteBizId { get; set; }

        /// <summary>
        /// 报价失败错误码，这个很重要
        /// </summary>
        [XmlElement("quote_error_code")]
        public string QuoteErrorCode { get; set; }

        /// <summary>
        /// 报价失败提示信息
        /// </summary>
        [XmlElement("quote_error_msg")]
        public string QuoteErrorMsg { get; set; }

        /// <summary>
        /// 实付保费[优惠后用户应付金额]
        /// </summary>
        [XmlElement("real_premium")]
        public string RealPremium { get; set; }

        /// <summary>
        /// 优惠保费
        /// </summary>
        [XmlElement("reduce_premium")]
        public string ReducePremium { get; set; }

        /// <summary>
        /// 保司自主渠道系数，精确到小数点后十位
        /// </summary>
        [XmlElement("self_channel_ratio")]
        public string SelfChannelRatio { get; set; }

        /// <summary>
        /// 保司自主核保系数，精确到小数点后十位
        /// </summary>
        [XmlElement("self_underwrite_ratio")]
        public string SelfUnderwriteRatio { get; set; }

        /// <summary>
        /// 总保费
        /// </summary>
        [XmlElement("total_premium")]
        public string TotalPremium { get; set; }

        /// <summary>
        /// 交通违法系数,精确到小数点后两位
        /// </summary>
        [XmlElement("traffic_violation_ratio")]
        public string TrafficViolationRatio { get; set; }

        /// <summary>
        /// 用户提醒code
        /// </summary>
        [XmlElement("warn_code")]
        public string WarnCode { get; set; }

        /// <summary>
        /// 用户提示内容
        /// </summary>
        [XmlElement("warn_message")]
        public string WarnMessage { get; set; }
    }
}
