using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// IntelligentGuideTradeDetail Data Structure.
    /// </summary>
    [Serializable]
    public class IntelligentGuideTradeDetail : AopObject
    {
        /// <summary>
        /// 非必填，商户会员的会员卡类型
        /// </summary>
        [XmlElement("card_type")]
        public string CardType { get; set; }

        /// <summary>
        /// 客户类型，支持枚举值：轮牌 - LP、指牌 - ZP。非必填
        /// </summary>
        [XmlElement("customer_type")]
        public string CustomerType { get; set; }

        /// <summary>
        /// 交易发生时间，精确到天。
        /// </summary>
        [XmlElement("date")]
        public string Date { get; set; }

        /// <summary>
        /// 第五推荐语，同上
        /// </summary>
        [XmlElement("fifth_recommendation")]
        public string FifthRecommendation { get; set; }

        /// <summary>
        /// 商户服务项目产品的一级类目，是一个枚举enum类型。项目/商品/卡项。单选、必填。
        /// </summary>
        [XmlElement("first_category")]
        public string FirstCategory { get; set; }

        /// <summary>
        /// 第一推荐语，选填项。用于商家描述产品优势，推荐理由。
        /// </summary>
        [XmlElement("first_recommendation")]
        public string FirstRecommendation { get; set; }

        /// <summary>
        /// 第四推荐语，同上
        /// </summary>
        [XmlElement("fourth_recommendation")]
        public string FourthRecommendation { get; set; }

        /// <summary>
        /// 通过智能导购查询智能推荐的推荐记录ID，用于反馈给算法进行模型校准。非必填
        /// </summary>
        [XmlElement("guide_record_id")]
        public string GuideRecordId { get; set; }

        /// <summary>
        /// 商户提供服务的商品名称(三级类目)，是二级类目下的细化具体项目品种名称。
        /// </summary>
        [XmlElement("item_name")]
        public string ItemName { get; set; }

        /// <summary>
        /// 交易用户的手机号，校验纯数字，11位。
        /// </summary>
        [XmlElement("mobile")]
        public string Mobile { get; set; }

        /// <summary>
        /// 原价金额，粒度精确到分（0.01元）。例：100代表1元。10代表0.1元。校验数字，大于0。
        /// </summary>
        [XmlElement("original_price")]
        public string OriginalPrice { get; set; }

        /// <summary>
        /// 支付方式，多种类型可用逗号分隔
        /// </summary>
        [XmlElement("payment_type")]
        public string PaymentType { get; set; }

        /// <summary>
        /// 实际消费金额，粒度精确到分(0.01元)，同original_price。
        /// </summary>
        [XmlElement("price")]
        public string Price { get; set; }

        /// <summary>
        /// 商户提供服务的二级类目，是一级类目下的细化项目名称
        /// </summary>
        [XmlElement("second_category")]
        public string SecondCategory { get; set; }

        /// <summary>
        /// 第二推荐语，选填项。用于商家描述产品优势，推荐理由。
        /// </summary>
        [XmlElement("second_recommendation")]
        public string SecondRecommendation { get; set; }

        /// <summary>
        /// 服务员工名，或员工ID，非必填
        /// </summary>
        [XmlElement("service_staff")]
        public string ServiceStaff { get; set; }

        /// <summary>
        /// 第三推荐语，选填项。用于商家描述产品优势，推荐理由。
        /// </summary>
        [XmlElement("third_recommendation")]
        public string ThirdRecommendation { get; set; }
    }
}
