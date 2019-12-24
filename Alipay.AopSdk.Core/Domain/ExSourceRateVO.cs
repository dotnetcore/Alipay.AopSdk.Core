using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// ExSourceRateVO Data Structure.
    /// </summary>
    [Serializable]
    public class ExSourceRateVO : AopObject
    {
        /// <summary>
        /// 买入价
        /// </summary>
        [XmlElement("bid")]
        public string Bid { get; set; }

        /// <summary>
        /// 报价币种对
        /// </summary>
        [XmlElement("currency_pair")]
        public string CurrencyPair { get; set; }

        /// <summary>
        /// 报价单位
        /// </summary>
        [XmlElement("currency_unit")]
        public long CurrencyUnit { get; set; }

        /// <summary>
        /// 价格失效时间
        /// </summary>
        [XmlElement("expiry_time")]
        public string ExpiryTime { get; set; }

        /// <summary>
        /// 扩展字段
        /// </summary>
        [XmlElement("extended_params")]
        public string ExtendedParams { get; set; }

        /// <summary>
        /// 报价生成日期
        /// </summary>
        [XmlElement("generate_date")]
        public string GenerateDate { get; set; }

        /// <summary>
        /// 报价生成时间
        /// </summary>
        [XmlElement("generate_time")]
        public string GenerateTime { get; set; }

        /// <summary>
        /// 创建日期
        /// </summary>
        [XmlElement("gmt_create")]
        public string GmtCreate { get; set; }

        /// <summary>
        /// 修改时间
        /// </summary>
        [XmlElement("gmt_modified")]
        public string GmtModified { get; set; }

        /// <summary>
        /// 报价是否可成交
        /// </summary>
        [XmlElement("guaranteed")]
        public string Guaranteed { get; set; }

        /// <summary>
        /// 主键id
        /// </summary>
        [XmlElement("id")]
        public string Id { get; set; }

        /// <summary>
        /// 源汇率机构
        /// </summary>
        [XmlElement("inst")]
        public string Inst { get; set; }

        /// <summary>
        /// 报价源报价ID
        /// </summary>
        [XmlElement("inst_rate_reference_id")]
        public string InstRateReferenceId { get; set; }

        /// <summary>
        /// 是否异常源汇率，Y或者N
        /// </summary>
        [XmlElement("is_exception")]
        public string IsException { get; set; }

        /// <summary>
        /// 是否平盘价
        /// </summary>
        [XmlElement("is_flat")]
        public string IsFlat { get; set; }

        /// <summary>
        /// 是否需要格式化，Y或者N
        /// </summary>
        [XmlElement("is_formatted")]
        public string IsFormatted { get; set; }

        /// <summary>
        /// 汇率是否有效
        /// </summary>
        [XmlElement("is_valid")]
        public string IsValid { get; set; }

        /// <summary>
        /// 远期或掉期点价格到期日
        /// </summary>
        [XmlElement("maturity_date")]
        public string MaturityDate { get; set; }

        /// <summary>
        /// 该价格的最大买入量
        /// </summary>
        [XmlElement("maximum_bid_amount")]
        public long MaximumBidAmount { get; set; }

        /// <summary>
        /// 该价格的最大卖出量
        /// </summary>
        [XmlElement("maximum_offer_amount")]
        public long MaximumOfferAmount { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        [XmlElement("memo")]
        public string Memo { get; set; }

        /// <summary>
        /// 中间价
        /// </summary>
        [XmlElement("mid")]
        public string Mid { get; set; }

        /// <summary>
        /// 该价格的最小买入量
        /// </summary>
        [XmlElement("minimum_bid_amount")]
        public long MinimumBidAmount { get; set; }

        /// <summary>
        /// 该价格的最小卖出量
        /// </summary>
        [XmlElement("minimum_offer_amount")]
        public long MinimumOfferAmount { get; set; }

        /// <summary>
        /// 卖出价
        /// </summary>
        [XmlElement("offer")]
        public string Offer { get; set; }

        /// <summary>
        /// 在岸/离岸标识:ON/OFF
        /// </summary>
        [XmlElement("on_off_shore")]
        public string OnOffShore { get; set; }

        /// <summary>
        /// 期限(TODAY,TOM,SPOT)
        /// </summary>
        [XmlElement("period")]
        public string Period { get; set; }

        /// <summary>
        /// 业务自定义字段
        /// </summary>
        [XmlElement("profile")]
        public string Profile { get; set; }

        /// <summary>
        /// 价格类型 WHL/RTL
        /// </summary>
        [XmlElement("quote_type")]
        public string QuoteType { get; set; }

        /// <summary>
        /// 报价生成方式，用来区分人工指定报价或者渠道原始报价
        /// </summary>
        [XmlElement("rate_method")]
        public string RateMethod { get; set; }

        /// <summary>
        /// 源汇率编码
        /// </summary>
        [XmlElement("rate_source_code")]
        public string RateSourceCode { get; set; }

        /// <summary>
        /// 产品类型：即期，远期，掉期
        /// </summary>
        [XmlElement("rate_type")]
        public string RateType { get; set; }

        /// <summary>
        /// 端标识号
        /// </summary>
        [XmlElement("segment_id")]
        public string SegmentId { get; set; }

        /// <summary>
        /// 即期买入价
        /// </summary>
        [XmlElement("sp_bid")]
        public string SpBid { get; set; }

        /// <summary>
        /// 即期中间价
        /// </summary>
        [XmlElement("sp_mid")]
        public string SpMid { get; set; }

        /// <summary>
        /// 即期卖出价
        /// </summary>
        [XmlElement("sp_offer")]
        public string SpOffer { get; set; }

        /// <summary>
        /// 价格生效时间
        /// </summary>
        [XmlElement("start_time")]
        public string StartTime { get; set; }

        /// <summary>
        /// 子机构
        /// </summary>
        [XmlElement("sub_inst")]
        public string SubInst { get; set; }

        /// <summary>
        /// 报价缓冲时间
        /// </summary>
        [XmlElement("threshold_time")]
        public string ThresholdTime { get; set; }

        /// <summary>
        /// 最晚用此报价发送交易时间
        /// </summary>
        [XmlElement("valid_time")]
        public string ValidTime { get; set; }

        /// <summary>
        /// 价格失效时间(带时区)
        /// </summary>
        [XmlElement("zone_expiry_time")]
        public string ZoneExpiryTime { get; set; }

        /// <summary>
        /// 报价生成时间(带时区)
        /// </summary>
        [XmlElement("zone_generate_time")]
        public string ZoneGenerateTime { get; set; }

        /// <summary>
        /// 创建日期(带时区)
        /// </summary>
        [XmlElement("zone_gmt_create")]
        public string ZoneGmtCreate { get; set; }

        /// <summary>
        /// 修改时间(带时区)
        /// </summary>
        [XmlElement("zone_gmt_modified")]
        public string ZoneGmtModified { get; set; }

        /// <summary>
        /// 价格生效时间(带时区)
        /// </summary>
        [XmlElement("zone_start_time")]
        public string ZoneStartTime { get; set; }

        /// <summary>
        /// 报价缓冲时间(带时区)
        /// </summary>
        [XmlElement("zone_threshold_time")]
        public string ZoneThresholdTime { get; set; }

        /// <summary>
        /// 最晚用此报价发送交易时间(带时区)
        /// </summary>
        [XmlElement("zone_valid_time")]
        public string ZoneValidTime { get; set; }
    }
}
