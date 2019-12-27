using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Response
{
    /// <summary>
    /// AlipayFundBatchCreateResponse.
    /// </summary>
    public class AlipayFundBatchCreateResponse : AopResponse
    {
        /// <summary>
        /// 支付宝内部的批次ID
        /// </summary>
        [XmlElement("batch_trans_id")]
        public string BatchTransId { get; set; }

        /// <summary>
        /// 商户的批次号
        /// </summary>
        [XmlElement("out_batch_no")]
        public string OutBatchNo { get; set; }

        /// <summary>
        /// INIT：批次落单成功
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
