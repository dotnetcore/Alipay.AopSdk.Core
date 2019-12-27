using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// AlipayTradeBatchSettleQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayTradeBatchSettleQueryModel : AopObject
    {
        /// <summary>
        /// 扩展参数
        /// </summary>
        [XmlElement("extend_params")]
        public string ExtendParams { get; set; }

        /// <summary>
        /// 批量结算时传入的外部流水号，与settle_no二者必填其一。 out_request_no和settle_no如果同时存在，优先取settle_no
        /// </summary>
        [XmlElement("out_request_no")]
        public string OutRequestNo { get; set; }

        /// <summary>
        /// 结算单据号，与out_request_no二者必填其一
        /// </summary>
        [XmlElement("settle_no")]
        public string SettleNo { get; set; }
    }
}
