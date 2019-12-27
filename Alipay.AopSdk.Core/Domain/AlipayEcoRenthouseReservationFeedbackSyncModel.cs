using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// AlipayEcoRenthouseReservationFeedbackSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEcoRenthouseReservationFeedbackSyncModel : AopObject
    {
        /// <summary>
        /// 备注
        /// </summary>
        [XmlElement("audit_comment")]
        public string AuditComment { get; set; }

        /// <summary>
        /// 商户确认的看房时间（如果跟租客确定的时间不一致）
        /// </summary>
        [XmlElement("final_look_time")]
        public string FinalLookTime { get; set; }

        /// <summary>
        /// 带看房人姓名
        /// </summary>
        [XmlElement("looker_name")]
        public string LookerName { get; set; }

        /// <summary>
        /// 带看房人电话
        /// </summary>
        [XmlElement("looker_phone")]
        public string LookerPhone { get; set; }

        /// <summary>
        /// 比如某种业务标准外部订单号,比如交易外部订单号，代表商户端自己订单号
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 预约单流水号，唯一标识指定预约单
        /// </summary>
        [XmlElement("reservation_no")]
        public string ReservationNo { get; set; }

        /// <summary>
        /// 商户端反馈租户是否预约成功！  SUCCESS：预约成功  FAIL：预约失败  CANCEL：预约取消(必须先预约成功处理)
        /// </summary>
        [XmlElement("reserve_status")]
        public string ReserveStatus { get; set; }

        /// <summary>
        /// 商户端房源编号
        /// </summary>
        [XmlElement("room_code")]
        public string RoomCode { get; set; }
    }
}
