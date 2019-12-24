using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// BatchDetailInfo Data Structure.
    /// </summary>
    [Serializable]
    public class BatchDetailInfo : AopObject
    {
        /// <summary>
        /// 批次号
        /// </summary>
        [XmlElement("batch_no")]
        public string BatchNo { get; set; }

        /// <summary>
        /// 明细批次号
        /// </summary>
        [XmlElement("detail_no")]
        public string DetailNo { get; set; }

        /// <summary>
        /// 调用方扩充参数
        /// </summary>
        [XmlElement("ext_param")]
        public string ExtParam { get; set; }

        /// <summary>
        /// 失败原因：在status为fail时此字段不为空
        /// </summary>
        [XmlElement("fail_message")]
        public string FailMessage { get; set; }

        /// <summary>
        /// 最后修改时间，指失败时间、成功时间、创建时间等，明细最后一次变更状态的时间
        /// </summary>
        [XmlElement("last_modified")]
        public string LastModified { get; set; }

        /// <summary>
        /// 付款人留言
        /// </summary>
        [XmlElement("message")]
        public string Message { get; set; }

        /// <summary>
        /// 付款金额，单位为元，有两位小数
        /// </summary>
        [XmlElement("pay_amount")]
        public string PayAmount { get; set; }

        /// <summary>
        /// 支付成功时间
        /// </summary>
        [XmlElement("pay_success_date")]
        public string PaySuccessDate { get; set; }

        /// <summary>
        /// 批次明细状态  AVAILABLE：可付款  SUCCESS：付款成功
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 付款订单号
        /// </summary>
        [XmlElement("transfer_no")]
        public string TransferNo { get; set; }

        /// <summary>
        /// 付款人UID
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
