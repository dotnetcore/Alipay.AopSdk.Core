using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// MybankPaymentTradeNormalpayOrderCreateandpayModel Data Structure.
    /// </summary>
    [Serializable]
    public class MybankPaymentTradeNormalpayOrderCreateandpayModel : AopObject
    {
        /// <summary>
        /// 金额，单位：分
        /// </summary>
        [XmlElement("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// 外部平台的单据号，网商订单与外部平台订单一一对应
        /// </summary>
        [XmlElement("biz_no")]
        public string BizNo { get; set; }

        /// <summary>
        /// 币种
        /// </summary>
        [XmlElement("currency_value")]
        public string CurrencyValue { get; set; }

        /// <summary>
        /// 扩展参数，内容是JSON格式，并用urlconde编码，按场景约定具体字段。
        /// </summary>
        [XmlElement("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 操作场景类型 CHARGE - 收费
        /// </summary>
        [XmlElement("operate_scene_type")]
        public string OperateSceneType { get; set; }

        /// <summary>
        /// 收方资产信息，内容是JSON格式，并用urlencode编码，按场景约定具体字段
        /// </summary>
        [XmlElement("payee_fund_detail")]
        public string PayeeFundDetail { get; set; }

        /// <summary>
        /// 付方资产信息，内容是JSON格式，并用urlencode编码，按场景约定具体字段
        /// </summary>
        [XmlElement("payer_fund_detail")]
        public string PayerFundDetail { get; set; }

        /// <summary>
        /// 支付备注
        /// </summary>
        [XmlElement("remark")]
        public string Remark { get; set; }

        /// <summary>
        /// 请求流水号，表示外部一次请求，幂等字段
        /// </summary>
        [XmlElement("request_no")]
        public string RequestNo { get; set; }

        /// <summary>
        /// 请求时间，格式是yyyyMMddHHmmss
        /// </summary>
        [XmlElement("request_time")]
        public string RequestTime { get; set; }
    }
}
