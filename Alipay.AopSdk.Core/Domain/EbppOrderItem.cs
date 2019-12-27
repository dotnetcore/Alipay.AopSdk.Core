using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// EbppOrderItem Data Structure.
    /// </summary>
    [Serializable]
    public class EbppOrderItem : AopObject
    {
        /// <summary>
        /// 支付宝对该子项所代表的这笔业务的唯一标识。
        /// </summary>
        [XmlElement("alipay_item_id")]
        public string AlipayItemId { get; set; }

        /// <summary>
        /// 业务金额
        /// </summary>
        [XmlElement("biz_amount")]
        public string BizAmount { get; set; }

        /// <summary>
        /// 业务产品id，由支付宝分配。
        /// </summary>
        [XmlElement("biz_prod_id")]
        public string BizProdId { get; set; }

        /// <summary>
        /// 用于传递扩展参数
        /// </summary>
        [XmlElement("extend_field")]
        public string ExtendField { get; set; }

        /// <summary>
        /// 机构端对该子项所代表的这笔业务的唯一标识。
        /// </summary>
        [XmlElement("inst_item_id")]
        public string InstItemId { get; set; }

        /// <summary>
        /// 支付宝流水号
        /// </summary>
        [XmlElement("linked_bill_no")]
        public string LinkedBillNo { get; set; }

        /// <summary>
        /// 业务状态  I - 初始状态，未支付  C - 已关单，不能继续支付  P - 已支付  S - 业务成功  F - 业务失败，退款给用户
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
