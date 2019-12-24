using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// OpenApiRefundFundDetailPojo Data Structure.
    /// </summary>
    [Serializable]
    public class OpenApiRefundFundDetailPojo : AopObject
    {
        /// <summary>
        /// 退款资金明细  详：  若type为paySerialNo则funds为  [{"paySerialNo":"支付流水1","refundFee":"退款金额1"},{"paySerialNo":"支付流水2","refundFee":"退款金额2"}]
        /// </summary>
        [XmlArray("funds")]
        [XmlArrayItem("string")]
        public List<string> Funds { get; set; }

        /// <summary>
        /// 收入方账户  为空则原路退回
        /// </summary>
        [XmlElement("trans_in")]
        public string TransIn { get; set; }

        /// <summary>
        /// 收入方账户类型
        /// </summary>
        [XmlElement("trans_in_type")]
        public string TransInType { get; set; }

        /// <summary>
        /// 描述资金明细类型  详：若type为paySerialNo  则funds参数中体现的都为对应支付流水的退款明细
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }
    }
}
