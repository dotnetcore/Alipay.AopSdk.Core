using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// AlipayDataAiserviceSmartpriceMerchanteffectQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayDataAiserviceSmartpriceMerchanteffectQueryModel : AopObject
    {
        /// <summary>
        /// 内部接口版本号
        /// </summary>
        [XmlElement("app_version")]
        public string AppVersion { get; set; }

        /// <summary>
        /// 结束时间
        /// </summary>
        [XmlElement("end_time")]
        public string EndTime { get; set; }

        /// <summary>
        /// 商户Id
        /// </summary>
        [XmlElement("merchant_id")]
        public string MerchantId { get; set; }

        /// <summary>
        /// 标识定价场景 single_pay:单次支付定价stored_value_card:储值卡
        /// </summary>
        [XmlElement("scene_code")]
        public string SceneCode { get; set; }

        /// <summary>
        /// 接入方名称,不同业务方的区分
        /// </summary>
        [XmlElement("service_name")]
        public string ServiceName { get; set; }

        /// <summary>
        /// 开始时间,传""表示返回开启服务后的所有记录
        /// </summary>
        [XmlElement("start_time")]
        public string StartTime { get; set; }

        /// <summary>
        /// 最小定价单元ID,传""时统计该商家下所有定价单元指标之和
        /// </summary>
        [XmlElement("unit_id")]
        public string UnitId { get; set; }
    }
}
