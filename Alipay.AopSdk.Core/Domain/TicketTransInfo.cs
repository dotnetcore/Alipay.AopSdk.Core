using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// TicketTransInfo Data Structure.
    /// </summary>
    [Serializable]
    public class TicketTransInfo : AopObject
    {
        /// <summary>
        /// 流水创建时间
        /// </summary>
        [XmlElement("create_time")]
        public string CreateTime { get; set; }

        /// <summary>
        /// 最后修改时间，也就是流水状态更新为成功的时间
        /// </summary>
        [XmlElement("last_modify_time")]
        public string LastModifyTime { get; set; }

        /// <summary>
        /// 流水涉及凭证数量，若为普通商品则为1， 若为次卡则为操作的凭证份数
        /// </summary>
        [XmlElement("quantity")]
        public string Quantity { get; set; }

        /// <summary>
        /// 凭证流水id
        /// </summary>
        [XmlElement("ticket_trans_id")]
        public string TicketTransId { get; set; }

        /// <summary>
        /// 流水类型
        /// </summary>
        [XmlElement("ticket_trans_type")]
        public string TicketTransType { get; set; }
    }
}
