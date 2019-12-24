using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// ZhimaCreditPeIndustryTradeCloseModel Data Structure.
    /// </summary>
    [Serializable]
    public class ZhimaCreditPeIndustryTradeCloseModel : AopObject
    {
        /// <summary>
        /// 关闭时间,接入方通过其他渠道实际收款时间,应小于当前时间. 可空,不传将默认取服务器当前时间
        /// </summary>
        [XmlElement("close_time")]
        public string CloseTime { get; set; }

        /// <summary>
        /// 扩展信息字段，格式:json，注意，如果字符串对应的json对象包含中文字符，需要对包含中文的字段进行编码
        /// </summary>
        [XmlElement("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 操作类型,close:资金单关闭,finish:资金单完结,已经通过其他渠道完成交易
        /// </summary>
        [XmlElement("operate")]
        public string Operate { get; set; }

        /// <summary>
        /// 商户扣款时传入的扣款资金单号，需要保证唯一
        /// </summary>
        [XmlElement("out_fund_no")]
        public string OutFundNo { get; set; }

        /// <summary>
        /// 签约产品码
        /// </summary>
        [XmlElement("product_code")]
        public string ProductCode { get; set; }

        /// <summary>
        /// 平台订单号
        /// </summary>
        [XmlElement("zm_order_id")]
        public string ZmOrderId { get; set; }
    }
}
