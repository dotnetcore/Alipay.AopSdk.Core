using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// AlipayCommerceTransportVehicleownerBlacklistSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceTransportVehicleownerBlacklistSyncModel : AopObject
    {
        /// <summary>
        /// 支付宝生成的签约协议编号
        /// </summary>
        [XmlElement("agreement_no")]
        public string AgreementNo { get; set; }

        /// <summary>
        /// ETC车牌颜色代码。0:蓝色, 1:黄色, 2:黑色, 3:白色, 4:渐变绿色
        /// </summary>
        [XmlElement("plate_color")]
        public string PlateColor { get; set; }

        /// <summary>
        /// 车牌号码
        /// </summary>
        [XmlElement("plate_no")]
        public string PlateNo { get; set; }

        /// <summary>
        /// 黑名单来源渠道标识。具体传值由支付宝和调用方在接入前分配。
        /// </summary>
        [XmlElement("source")]
        public string Source { get; set; }

        /// <summary>
        /// 黑名单操作类型。IN:入黑名单，OUT:出黑名单
        /// </summary>
        [XmlElement("status_opt")]
        public string StatusOpt { get; set; }

        /// <summary>
        /// 黑名单状态操作时间
        /// </summary>
        [XmlElement("status_opt_time")]
        public string StatusOptTime { get; set; }

        /// <summary>
        /// 入黑/出黑原因
        /// </summary>
        [XmlElement("status_reason")]
        public string StatusReason { get; set; }

        /// <summary>
        /// 入黑/出黑原因代码。操作为入黑时，该字段必须；操作为出黑时，该字段不传值。
        /// </summary>
        [XmlElement("status_reason_code")]
        public string StatusReasonCode { get; set; }
    }
}
